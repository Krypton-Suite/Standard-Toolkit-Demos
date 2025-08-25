@echo off
setlocal EnableExtensions EnableDelayedExpansion

rem Usage: build-all.cmd [Configuration] [Mode] [Rebuild]
rem   Configuration: Debug or Release (default: Release)
rem   Mode: all | nuget | dev (default: all)
rem   Rebuild: on | off (default: on)

if "%~1"=="" if "%~2"=="" if "%~3"=="" (
  echo.
  echo Usage: build-all.cmd [Configuration] [Mode] [Rebuild]
  echo   Configuration: Debug or Release ^(default: Release^)
  echo   Mode: all ^| nuget ^| dev ^(default: all^)
  echo   Rebuild: on ^| off ^(default: on^)
  echo.
  echo Examples:
  echo   build-all.cmd Release all on
  echo   build-all.cmd Debug nuget off
  exit /b 0
)

set "CONFIG=%~1"
if "%CONFIG%"=="" set "CONFIG=Release"
set "MODE=%~2"
if "%MODE%"=="" set "MODE=all"
set "REBUILD=%~3"
if /i "%REBUILD%"=="" set "REBUILD=on"

set "TARGET=/t:Build"
if /i "%REBUILD%"=="on" set "TARGET=/t:Rebuild"

echo ======================================================
echo Building solutions - Configuration: %CONFIG% - Mode: %MODE% - Rebuild: %REBUILD%
echo Repo: %CD%
echo ======================================================

set "MSBUILD="

rem Prefer explicit Visual Studio 2022 MSBuild locations (version 17.x only)
if exist "%ProgramFiles%\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\MSBuild.exe"
if not defined MSBUILD if exist "%ProgramFiles%\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\MSBuild.exe"
if not defined MSBUILD if exist "%ProgramFiles%\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe"
if not defined MSBUILD if exist "%ProgramFiles%\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe"
if not defined MSBUILD if exist "%ProgramFiles%\Microsoft Visual Studio\2022\BuildTools\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\2022\BuildTools\MSBuild\Current\Bin\MSBuild.exe"

rem Fallback to vswhere discovery, restricted to VS 2022 (17.x)
if not defined MSBUILD (
  set "VSWHERE=%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe"
  if exist "%VSWHERE%" (
    for /f "usebackq delims=" %%i in (`"%VSWHERE%" -latest -products * -requires Microsoft.Component.MSBuild -version "[17.0,18.0)" -find MSBuild\**\Bin\MSBuild.exe`) do set "MSBUILD=%%i"
    if not defined MSBUILD (
      for /f "usebackq delims=" %%i in (`"%VSWHERE%" -latest -prerelease -products * -requires Microsoft.Component.MSBuild -version "[17.0,18.0)" -find MSBuild\**\Bin\MSBuild.exe`) do set "MSBUILD=%%i"
    )
  )
)

if defined MSBUILD (
  if exist "%MSBUILD%" (
    echo Using MSBuild: %MSBUILD%
  ) else (
    echo ERROR: Resolved MSBuild path not found: %MSBUILD%
    exit /b 1
  )
) else (
  echo ERROR: Visual Studio 2022 MSBuild not found. Ensure VS 2022 Build Tools are installed.
  exit /b 1
)

set "LOGDIR=Binaries\BuildLogs"
if not exist "%LOGDIR%" mkdir "%LOGDIR%" >nul 2>&1
set "FAILED_LOG=%LOGDIR%\_failed.txt"
if exist "%FAILED_LOG%" del /q "%FAILED_LOG%" >nul 2>&1

set BUILD_ERRORS=0

if /i "%MODE%"=="nuget" goto :BUILD_NUGET
if /i "%MODE%"=="dev" goto :BUILD_DEV

:BUILD_NUGET
echo.
echo === Building NuGet solutions ===
for /f "delims=" %%F in ('dir /b /s "* - Nuget.sln"') do (
  echo.
  echo --- Building: %%~fF ---
  "%MSBUILD%" "%%~fF" /m /nologo /v:quiet /clp:Summary;ShowTimestamp /restore %TARGET% /p:Configuration=%CONFIG% /bl:"%LOGDIR%\%%~nF.binlog"
  if errorlevel 1 (
    echo !!! FAILED: %%~fF
    echo %%~fF>>"%FAILED_LOG%"
    set /a BUILD_ERRORS+=1
  ) else (
    echo SUCCESS: %%~fF
  )
)
if /i "%MODE%"=="nuget" goto :SUMMARY

:BUILD_DEV
echo.
echo === Building Dev solutions ===
set "EXPECTED_ST_ROOT=%CD%\..\Standard-Toolkit"
if not exist "%EXPECTED_ST_ROOT%" (
  echo WARNING: Expected Standard-Toolkit repo at "%EXPECTED_ST_ROOT%" for Dev solutions.
)
for /f "delims=" %%F in ('dir /b /s "* - Dev.sln"') do (
  echo.
  echo --- Building: %%~fF ---
  "%MSBUILD%" "%%~fF" /m /nologo /v:quiet /clp:Summary;ShowTimestamp /restore %TARGET% /p:Configuration=%CONFIG% /bl:"%LOGDIR%\%%~nF.binlog"
  if errorlevel 1 (
    echo !!! FAILED: %%~fF
    echo %%~fF>>"%FAILED_LOG%"
    set /a BUILD_ERRORS+=1
  ) else (
    echo SUCCESS: %%~fF
  )
)

:SUMMARY
echo.
echo ======================================================
echo Build finished with %BUILD_ERRORS% error(s).
echo Logs: %LOGDIR%
if exist "%FAILED_LOG%" (
  echo.
  echo Failed solutions:
  type "%FAILED_LOG%"
  echo.
  echo See binlogs above for details per solution.
)
if not exist "%FAILED_LOG%" (
  echo All solutions built successfully.
)
echo ======================================================

exit /b %BUILD_ERRORS%
