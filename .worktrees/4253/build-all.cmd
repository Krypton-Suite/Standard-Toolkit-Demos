@echo off
setlocal EnableExtensions EnableDelayedExpansion

rem Usage: build-all.cmd [Configuration] [Mode] [Rebuild] [Toolset]
rem   Configuration: Debug or Release (default: Release)
rem   Mode: all | nuget | dev (default: all)
rem   Rebuild: on | off (default: on)
rem   Toolset: 2022 | 2026 | auto (default: 2022)

set "SCRIPT_DIR=%~dp0"
pushd "%SCRIPT_DIR%"

if /i "%~1"=="help" goto :USAGE
if /i "%~1"=="/?" goto :USAGE
if /i "%~1"=="-?" goto :USAGE
if /i "%~1"=="--help" goto :USAGE

if /i "%~2"=="nuget" if /i "%~3"=="off" (
  set "CONFIG=%~1"
  set "MODE=dev"
  set "REBUILD=on"
  set "TOOLSET=%~4"
  if /i "%~4"=="on" set "REBUILD=%~4" & set "TOOLSET=%~5"
  if /i "%~4"=="off" set "REBUILD=%~4" & set "TOOLSET=%~5"
  goto :ARGS_PARSED
)
if /i "%~2"=="dev" if /i "%~3"=="off" (
  set "CONFIG=%~1"
  set "MODE=nuget"
  set "REBUILD=on"
  set "TOOLSET=%~4"
  if /i "%~4"=="on" set "REBUILD=%~4" & set "TOOLSET=%~5"
  if /i "%~4"=="off" set "REBUILD=%~4" & set "TOOLSET=%~5"
  goto :ARGS_PARSED
)
if /i "%~2"=="nuget" if /i "%~3"=="on" (
  set "CONFIG=%~1"
  set "MODE=nuget"
  set "REBUILD=on"
  set "TOOLSET=%~4"
  if /i "%~4"=="on" set "REBUILD=%~4" & set "TOOLSET=%~5"
  if /i "%~4"=="off" set "REBUILD=%~4" & set "TOOLSET=%~5"
  goto :ARGS_PARSED
)
if /i "%~2"=="dev" if /i "%~3"=="on" (
  set "CONFIG=%~1"
  set "MODE=dev"
  set "REBUILD=on"
  set "TOOLSET=%~4"
  if /i "%~4"=="on" set "REBUILD=%~4" & set "TOOLSET=%~5"
  if /i "%~4"=="off" set "REBUILD=%~4" & set "TOOLSET=%~5"
  goto :ARGS_PARSED
)

if /i "%~1"=="nuget" if /i "%~2"=="off" (
  set "CONFIG=Release"
  set "MODE=dev"
  set "REBUILD=on"
  set "TOOLSET=%~3"
  if /i "%~3"=="on" set "REBUILD=%~3" & set "TOOLSET=%~4"
  if /i "%~3"=="off" set "REBUILD=%~3" & set "TOOLSET=%~4"
  goto :ARGS_PARSED
)
if /i "%~1"=="dev" if /i "%~2"=="off" (
  set "CONFIG=Release"
  set "MODE=nuget"
  set "REBUILD=on"
  set "TOOLSET=%~3"
  if /i "%~3"=="on" set "REBUILD=%~3" & set "TOOLSET=%~4"
  if /i "%~3"=="off" set "REBUILD=%~3" & set "TOOLSET=%~4"
  goto :ARGS_PARSED
)
if /i "%~1"=="nuget" if /i "%~2"=="on" (
  set "CONFIG=Release"
  set "MODE=nuget"
  set "REBUILD=on"
  set "TOOLSET=%~3"
  if /i "%~3"=="on" set "REBUILD=%~3" & set "TOOLSET=%~4"
  if /i "%~3"=="off" set "REBUILD=%~3" & set "TOOLSET=%~4"
  goto :ARGS_PARSED
)
if /i "%~1"=="dev" if /i "%~2"=="on" (
  set "CONFIG=Release"
  set "MODE=dev"
  set "REBUILD=on"
  set "TOOLSET=%~3"
  if /i "%~3"=="on" set "REBUILD=%~3" & set "TOOLSET=%~4"
  if /i "%~3"=="off" set "REBUILD=%~3" & set "TOOLSET=%~4"
  goto :ARGS_PARSED
)

set "CONFIG=%~1"
if "%CONFIG%"=="" set "CONFIG=Release"
set "MODE=%~2"
if "%MODE%"=="" set "MODE=all"
set "REBUILD=%~3"
if /i "%REBUILD%"=="" set "REBUILD=on"
set "TOOLSET=%~4"

:ARGS_PARSED
if "%TOOLSET%"=="" set "TOOLSET=2022"

if /i "%MODE%"=="all" goto :MODE_VALID
if /i "%MODE%"=="nuget" goto :MODE_VALID
if /i "%MODE%"=="dev" goto :MODE_VALID
echo ERROR: Unsupported mode "%MODE%". Use all, nuget, or dev.
set "EXIT_CODE=1"
goto :EXIT

:MODE_VALID
if /i "%REBUILD%"=="on" goto :REBUILD_VALID
if /i "%REBUILD%"=="off" goto :REBUILD_VALID
echo ERROR: Unsupported rebuild value "%REBUILD%". Use on or off.
set "EXIT_CODE=1"
goto :EXIT

:REBUILD_VALID
set "TARGET=/t:Build"
set "TARGET_NAME=Restore+Build"
set "TARGET_LOG=build"
set "RESTORE_ARG=/restore"
if /i "%REBUILD%"=="on" (
  set "TARGET_NAME=Build"
  set "TARGET_LOG=rebuild"
  set "RESTORE_ARG="
)

echo ======================================================
echo Building solutions - Configuration: %CONFIG% - Mode: %MODE% - Rebuild: %REBUILD% - Toolset: %TOOLSET%
echo Repo: %CD%
echo ======================================================

set "MSBUILD="
set "VS_TOOLSET="
set "MSBUILD_PROPS="
set "MSBUILD_NODE_OPTIONS=/m:4 /nr:false"

if /i "%TOOLSET%"=="auto" call :FIND_VS2022
if /i "%TOOLSET%"=="auto" if not defined MSBUILD call :FIND_VS2026
if /i "%TOOLSET%"=="2026" call :FIND_VS2026
if /i "%TOOLSET%"=="vs2026" call :FIND_VS2026
if /i "%TOOLSET%"=="current" call :FIND_VS2026
if /i "%TOOLSET%"=="18" call :FIND_VS2026
if /i "%TOOLSET%"=="2022" call :FIND_VS2022
if /i "%TOOLSET%"=="vs2022" call :FIND_VS2022
if /i "%TOOLSET%"=="17" call :FIND_VS2022

if not defined VS_TOOLSET (
  echo ERROR: Unsupported toolset "%TOOLSET%". Use 2022, 2026, or auto.
  set "EXIT_CODE=1"
  goto :EXIT
)

if defined MSBUILD (
  if exist "%MSBUILD%" (
    echo Using MSBuild: %MSBUILD%
  ) else (
    echo ERROR: Resolved MSBuild path not found: %MSBUILD%
    set "EXIT_CODE=1"
    goto :EXIT
  )
) else (
  echo ERROR: Visual Studio %VS_TOOLSET% MSBuild not found. Ensure the matching Build Tools are installed.
  set "EXIT_CODE=1"
  goto :EXIT
)

if "%VS_TOOLSET%"=="2022" (
  set "MSBUILD_PROPS=/p:ExcludeVs2022UnsupportedTargetFrameworks=true"
  echo Target frameworks: VS2022 excludes net10.0-windows and net11.0-windows.
) else (
  call :SETUP_DOTNET11_SDK
  if errorlevel 1 (
    set "MSBUILD_PROPS=/p:ExcludeNet11=true"
    echo WARNING: .NET 11 SDK not found under "%ProgramFiles%\dotnet\sdk"; net11.0-windows will be skipped.
  ) else (
    set "MSBUILD_PROPS=/p:ExcludeNet11=false"
    echo Using .NET 11 SDK: !DOTNET_11_SDK_VERSION!
  )
)

set "LOGDIR=%SCRIPT_DIR%Binaries\BuildLogs"
if not exist "%LOGDIR%" mkdir "%LOGDIR%" >nul 2>&1
set "FAILED_LOG=%LOGDIR%\_failed.txt"
if exist "%FAILED_LOG%" del /q "%FAILED_LOG%" >nul 2>&1
set "BUILD_STAGING_ROOT=%SCRIPT_DIR%Binaries\BuildStaging\%CONFIG%"
set "FINAL_OUTPUT_ROOT=%SCRIPT_DIR%Binaries\Krypton Demos\%CONFIG%"

set BUILD_ERRORS=0

if /i "%REBUILD%"=="on" (
  call :PROCESS_SELECTED_SOLUTIONS restore
  if not "!BUILD_ERRORS!"=="0" goto :SUMMARY
  call :CLEAR_BUILD_OUTPUTS
)
call :PROCESS_SELECTED_SOLUTIONS build
goto :SUMMARY

:PROCESS_SELECTED_SOLUTIONS
set "BUILD_PHASE=%~1"
if /i "%MODE%"=="nuget" (
  call :PROCESS_NUGET_SOLUTIONS "%BUILD_PHASE%"
  exit /b 0
)
if /i "%MODE%"=="dev" (
  call :PROCESS_DEV_SOLUTIONS "%BUILD_PHASE%"
  exit /b 0
)
call :PROCESS_NUGET_SOLUTIONS "%BUILD_PHASE%"
call :PROCESS_DEV_SOLUTIONS "%BUILD_PHASE%"
exit /b 0

:PROCESS_NUGET_SOLUTIONS
set "BUILD_PHASE=%~1"
echo.
if /i "%BUILD_PHASE%"=="restore" echo === Restore phase: NuGet solutions ===
if /i "%BUILD_PHASE%"=="build" echo === Build phase: NuGet solutions ===
for /f "delims=" %%F in ('dir /b /s "%SCRIPT_DIR%* - Nuget.sln"') do (
  call :PROCESS_SOLUTION "%%~fF" "%%~nF" "%BUILD_PHASE%"
)
exit /b 0

:PROCESS_DEV_SOLUTIONS
set "BUILD_PHASE=%~1"
echo.
if /i "%BUILD_PHASE%"=="restore" echo === Restore phase: Dev solutions ===
if /i "%BUILD_PHASE%"=="build" echo === Build phase: Dev solutions ===
set "EXPECTED_ST_ROOT=%SCRIPT_DIR%..\Standard-Toolkit"
if not exist "%EXPECTED_ST_ROOT%" (
  echo WARNING: Expected Standard-Toolkit repo at "%EXPECTED_ST_ROOT%" for Dev solutions.
)
for /f "delims=" %%F in ('dir /b /s "%SCRIPT_DIR%* - Dev.sln"') do (
  call :PROCESS_SOLUTION "%%~fF" "%%~nF" "%BUILD_PHASE%"
)
exit /b 0

:CLEAR_BUILD_OUTPUTS
echo.
echo === Clearing build outputs ===
if exist "%BUILD_STAGING_ROOT%" rd /s /q "%BUILD_STAGING_ROOT%" >nul 2>&1
if exist "%FINAL_OUTPUT_ROOT%" rd /s /q "%FINAL_OUTPUT_ROOT%" >nul 2>&1
exit /b 0

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

set "EXIT_CODE=%BUILD_ERRORS%"
goto :EXIT

:PROCESS_SOLUTION
set "SOLUTION_PATH=%~1"
set "LOG_NAME=%~2"
set "BUILD_PHASE=%~3"
call :SHOULD_BUILD_SOLUTION "%LOG_NAME%"
if errorlevel 1 goto :SKIP_SOLUTION
echo.
if /i "%BUILD_PHASE%"=="restore" (
  echo --- Restore only: !SOLUTION_PATH! ---
  call :RESTORE_SOLUTION "!SOLUTION_PATH!" "%LOG_NAME%"
  exit /b 0
)
echo --- Building: %SOLUTION_PATH% ---
call :BUILD_SOLUTION "%SOLUTION_PATH%" "%LOG_NAME%"
exit /b 0

:SKIP_SOLUTION
echo.
echo --- Skipping: %SOLUTION_PATH% [not %CONFIG%] ---
exit /b 0

:SHOULD_BUILD_SOLUTION
set "CANDIDATE_SOLUTION=%~1"
if /i "%CONFIG%"=="Debug" if not "%CANDIDATE_SOLUTION:(Release)=%"=="%CANDIDATE_SOLUTION%" exit /b 1
if /i "%CONFIG%"=="Release" if not "%CANDIDATE_SOLUTION:(Debug)=%"=="%CANDIDATE_SOLUTION%" exit /b 1
exit /b 0

:BUILD_SOLUTION
set "SOLUTION_PATH=%~1"
set "LOG_NAME=%~2"
call :MAKE_SAFE_NAME "%LOG_NAME%"

echo %TARGET_NAME%: %SOLUTION_PATH%
set "SOLUTION_STAGING_ROOT=%BUILD_STAGING_ROOT%\%LOG_SAFE_NAME%"
"%MSBUILD%" "%SOLUTION_PATH%" %MSBUILD_NODE_OPTIONS% /nologo /v:quiet "/clp:Summary;ShowTimestamp" %RESTORE_ARG% "%TARGET%" /p:Configuration=%CONFIG% /p:BuildAllIsolatedOutput=true "/p:BuildAllOutputRoot=%SOLUTION_STAGING_ROOT%/" "/p:KryptonBuildOutputRoot=%SOLUTION_STAGING_ROOT%/_StandardToolkit/" %MSBUILD_PROPS% "/bl:%LOGDIR%\%LOG_SAFE_NAME%.%TARGET_LOG%.binlog"
if errorlevel 1 (
  echo !!! FAILED %TARGET_NAME%: !SOLUTION_PATH!
  >>"%FAILED_LOG%" echo !SOLUTION_PATH!
  set /a BUILD_ERRORS+=1
  exit /b 1
)

call :MERGE_STAGING_OUTPUTS "%SOLUTION_STAGING_ROOT%"
if errorlevel 1 (
  echo !!! FAILED merge: !SOLUTION_PATH!
  >>"%FAILED_LOG%" echo !SOLUTION_PATH!
  set /a BUILD_ERRORS+=1
  exit /b 1
)

echo SUCCESS: %SOLUTION_PATH%
exit /b 0

:RESTORE_SOLUTION
set "SOLUTION_PATH=%~1"
set "LOG_NAME=%~2"
call :MAKE_SAFE_NAME "%LOG_NAME%"

echo Restore only: %SOLUTION_PATH%
set "SOLUTION_STAGING_ROOT=%BUILD_STAGING_ROOT%\%LOG_SAFE_NAME%"
"%MSBUILD%" "%SOLUTION_PATH%" %MSBUILD_NODE_OPTIONS% /nologo /v:quiet "/clp:NoSummary;ShowTimestamp" /t:Restore /p:Configuration=%CONFIG% /p:BuildAllIsolatedOutput=true "/p:BuildAllOutputRoot=%SOLUTION_STAGING_ROOT%/" "/p:KryptonBuildOutputRoot=%SOLUTION_STAGING_ROOT%/_StandardToolkit/" %MSBUILD_PROPS% "/bl:%LOGDIR%\%LOG_SAFE_NAME%.restore.binlog"
if errorlevel 1 (
  echo !!! FAILED Restore: !SOLUTION_PATH!
  >>"%FAILED_LOG%" echo !SOLUTION_PATH!
  set /a BUILD_ERRORS+=1
  exit /b 1
)

echo SUCCESS: %SOLUTION_PATH%
exit /b 0

:MAKE_SAFE_NAME
set "LOG_SAFE_NAME=%~1"
set "LOG_SAFE_NAME=%LOG_SAFE_NAME:(=_%"
set "LOG_SAFE_NAME=%LOG_SAFE_NAME:)=_%"
set "LOG_SAFE_NAME=%LOG_SAFE_NAME: =_%"
set "LOG_SAFE_NAME=%LOG_SAFE_NAME:-=_%"
exit /b 0

:MERGE_STAGING_OUTPUTS
set "STAGING_ROOT=%~1"
if not exist "%STAGING_ROOT%" exit /b 0
if not exist "%FINAL_OUTPUT_ROOT%" mkdir "%FINAL_OUTPUT_ROOT%" >nul 2>&1
for /d /r "%STAGING_ROOT%" %%D in (net*) do (
  if exist "%%~fD\*" (
    robocopy "%%~fD" "%FINAL_OUTPUT_ROOT%\%%~nxD" /E /NFL /NDL /NJH /NJS /NP >nul
    if !ERRORLEVEL! GEQ 8 exit /b 1
  )
)
exit /b 0

:USAGE
echo.
echo Usage: build-all.cmd [Configuration] [Mode] [Rebuild] [Toolset]
echo   Configuration: Debug or Release ^(default: Release^)
echo   Mode: all ^| nuget ^| dev ^(default: all^)
echo   Rebuild: on ^| off ^(default: on^)
echo   Toolset: 2022 ^| 2026 ^| auto ^(default: 2022^)
echo.
echo Examples:
echo   build-all.cmd
echo   build-all.cmd Release all on
echo   build-all.cmd Debug nuget on off 2022
echo   build-all.cmd Debug nuget off
echo   build-all.cmd nuget off
echo   build-all.cmd dev off
set "EXIT_CODE=0"
goto :EXIT

:EXIT
popd
exit /b %EXIT_CODE%

:FIND_VS2026
if defined MSBUILD exit /b 0
set "VS_TOOLSET=2026"
if exist "%ProgramFiles%\Microsoft Visual Studio\18\Insiders\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\18\Insiders\MSBuild\Current\Bin\MSBuild.exe"
if not defined MSBUILD if exist "%ProgramFiles%\Microsoft Visual Studio\18\Enterprise\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\18\Enterprise\MSBuild\Current\Bin\MSBuild.exe"
if not defined MSBUILD if exist "%ProgramFiles%\Microsoft Visual Studio\18\Professional\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\18\Professional\MSBuild\Current\Bin\MSBuild.exe"
if not defined MSBUILD if exist "%ProgramFiles%\Microsoft Visual Studio\18\Community\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\18\Community\MSBuild\Current\Bin\MSBuild.exe"
if not defined MSBUILD if exist "%ProgramFiles%\Microsoft Visual Studio\18\BuildTools\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\18\BuildTools\MSBuild\Current\Bin\MSBuild.exe"
if not defined MSBUILD call :FIND_VSWHERE "[18.0,19.0)"
exit /b 0

:FIND_VS2022
if defined MSBUILD exit /b 0
set "VS_TOOLSET=2022"
if exist "%ProgramFiles%\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\MSBuild.exe"
if not defined MSBUILD if exist "%ProgramFiles%\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\MSBuild.exe"
if not defined MSBUILD if exist "%ProgramFiles%\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe"
if not defined MSBUILD if exist "%ProgramFiles%\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe"
if not defined MSBUILD if exist "%ProgramFiles%\Microsoft Visual Studio\2022\BuildTools\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\2022\BuildTools\MSBuild\Current\Bin\MSBuild.exe"
if not defined MSBUILD call :FIND_VSWHERE "[17.0,18.0)"
exit /b 0

:FIND_VSWHERE
set "VSWHERE=%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe"
if exist "%VSWHERE%" (
  for /f "usebackq delims=" %%i in (`"%VSWHERE%" -latest -products * -requires Microsoft.Component.MSBuild -version "%~1" -find MSBuild\**\Bin\MSBuild.exe`) do set "MSBUILD=%%i"
  if not defined MSBUILD (
    for /f "usebackq delims=" %%i in (`"%VSWHERE%" -latest -prerelease -products * -requires Microsoft.Component.MSBuild -version "%~1" -find MSBuild\**\Bin\MSBuild.exe`) do set "MSBUILD=%%i"
  )
)
exit /b 0

:SETUP_DOTNET11_SDK
set "DOTNET_11_SDK_VERSION="
set "DOTNET_ROLL_FORWARD_TO_PRERELEASE=1"
for /f "delims=" %%S in ('dir /b /ad /o-n "%ProgramFiles%\dotnet\sdk\11.*" 2^>nul') do (
  set "DOTNET_11_SDK_VERSION=%%S"
  set "DOTNET_11_SDK_ROOT=%ProgramFiles%\dotnet\sdk\%%S"
  set "MSBuildSDKsPath=%ProgramFiles%\dotnet\sdk\%%S\Sdks"
  set "DOTNET_MSBUILD_SDK_RESOLVER_CLI_DIR=%ProgramFiles%\dotnet"
  set "DOTNET_MSBUILD_SDK_RESOLVER_SDKS_DIR=%ProgramFiles%\dotnet\sdk\%%S\Sdks"
  set "DOTNET_MSBUILD_SDK_RESOLVER_SDKS_VER=%%S"
  exit /b 0
)
exit /b 1
