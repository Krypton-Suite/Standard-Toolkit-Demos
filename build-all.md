# Build system

This guide includes sections in English, German, Spanish, and Simplified Chinese.

## English

### Overview

- Script: `build-all.cmd`
- Purpose: Build all solutions in this repo (NuGet- and Dev-based) with MSBuild, produce concise console output, and write binlogs.

### Prerequisites

- Visual Studio 2022 (any edition) or VS 2022 Build Tools. Visual Studio 2026 is optional for net10.0/net11.0 builds.
- .NET SDKs: net8.0, net9.0, net10.0, and net11.0 as needed by the selected toolset.
- For Dev solutions: sibling repo `..\Standard-Toolkit` on a matching branch.

### Usage

```sh
build-all.cmd [Configuration] [Mode] [Rebuild] [Toolset]
```

- Configuration: `Debug` or `Release` (default: `Release`)
- Mode: `all` | `nuget` | `dev` (default: `all`)
- Rebuild: `on` | `off` (default: `on`); `on` restores all selected solutions, clears the build output directories once, then builds them; `off` runs `/restore` and `/t:Build`.
- Toolset: `2022` | `2026` | `auto` (default: `2022`)
- Project-set toggles: `[Configuration] nuget off` skips NuGet solutions; `[Configuration] dev off` skips Dev solutions.
- Configuration-specific solution files are filtered: `Release` skips `(Debug)` solutions, and `Debug` skips `(Release)` solutions.

### Examples

- Build everything in Release with Rebuild (default):

```sh
build-all.cmd
```

- NuGet-only, Debug, Rebuild off (incremental):

```sh
build-all.cmd Debug nuget on off
```

- Dev-only, Release, Rebuild on:

```sh
build-all.cmd Release dev on
```

- Force VS 2022, which skips net10.0-windows and net11.0-windows:

```sh
build-all.cmd Release all on 2022
```

- Skip NuGet solutions and build Dev solutions only:

```sh
build-all.cmd Debug nuget off
```

### Output & Logs

- Binlogs: `Binaries\BuildLogs\<solution-name>.rebuild.binlog` or `Binaries\BuildLogs\<solution-name>.build.binlog`
- Failures summary: `Binaries\BuildLogs\_failed.txt` (printed at end if present)
- Console output: quiet with summary and timestamps
- Solutions are built with one MSBuild node to avoid shared output copy locks.

### Inspecting .binlog

- Recommended viewer: MSBuild Structured Log Viewer (`https://msbuildlog.com`).
- Or open `.binlog` directly in Visual Studio (File → Open → File).

### Notes

- The default toolset is Visual Studio 2022. Toolset `2026` opts into Visual Studio 2026, and `auto` tries Visual Studio 2022 before Visual Studio 2026.
- Visual Studio 2022 builds skip net10.0-windows and net11.0-windows. Visual Studio 2026 builds net11.0-windows only when a .NET 11 SDK is installed under `%ProgramFiles%\dotnet\sdk`.
- Dev builds warn if `..\Standard-Toolkit` is not present.

---

## Deutsch

### Übersicht

- Skript: `build-all.cmd`
- Zweck: Alle Lösungen (NuGet und Dev) mit MSBuild bauen, konsolen­ausgabe minimieren, Binlogs schreiben.

### Voraussetzungen

- Visual Studio 2022 (beliebige Edition) oder VS 2022 Build Tools. Visual Studio 2026 ist optional für net10.0/net11.0 Builds.
- Erforderliche .NET SDKs (z. B. net8.0, net9.0, net10.0, net11.0).
- Für Dev-Lösungen: Neben-Repo `..\Standard-Toolkit` auf passendem Branch.

### Verwendung

```sh
build-all.cmd [Configuration] [Mode] [Rebuild] [Toolset]
```

- Configuration: `Debug` oder `Release` (Standard: `Release`)
- Mode: `all` | `nuget` | `dev` (Standard: `all`)
- Rebuild: `on` | `off` (Standard: `on`); `on` stellt alle ausgewählten Solutions wieder her, leert die Build-Ausgabeverzeichnisse einmal und baut sie danach; `off` verwendet `/restore` und `/t:Build`.
- Toolset: `2022` | `2026` | `auto` (Standard: `2022`)
- Projektgruppen-Schalter: `[Configuration] nuget off` überspringt NuGet-Lösungen; `[Configuration] dev off` überspringt Dev-Lösungen.
- Konfigurationsspezifische Lösungsdateien werden gefiltert: `Release` überspringt `(Debug)`-Lösungen, und `Debug` überspringt `(Release)`-Lösungen.

### Beispiele

- Alles in Release mit Rebuild (Standard):

```sh
build-all.cmd
```

- Nur NuGet, Debug, Rebuild aus (inkrementell):

```sh
build-all.cmd Debug nuget on off
```

- Nur Dev, Release, Rebuild an:

```sh
build-all.cmd Release dev on
```

- VS 2022 erzwingen; net10.0-windows und net11.0-windows werden dabei übersprungen:

```sh
build-all.cmd Release all on 2022
```

- NuGet-Lösungen überspringen und nur Dev-Lösungen bauen:

```sh
build-all.cmd Debug nuget off
```

### Ausgaben & Logs

- Binlogs: `Binaries\BuildLogs\<solution-name>.rebuild.binlog` oder `Binaries\BuildLogs\<solution-name>.build.binlog`
- Fehlerliste: `Binaries\BuildLogs\_failed.txt` (wird am Ende ausgegeben, falls vorhanden)
- Konsole: ruhig, mit Zusammenfassung und Zeitstempeln
- Lösungen werden mit einem MSBuild-Knoten gebaut, um Kopiersperren im gemeinsamen Ausgabeverzeichnis zu vermeiden.

### Binlog ansehen

- Empfohlen: MSBuild Structured Log Viewer (`https://msbuildlog.com`).
- Alternativ: `.binlog` direkt in Visual Studio öffnen (Datei → Öffnen → Datei).

### Hinweise

- Das Standard-Toolset ist Visual Studio 2022. Toolset `2026` wählt Visual Studio 2026 explizit aus, und `auto` versucht Visual Studio 2022 vor Visual Studio 2026.
- Visual Studio 2022 Builds überspringen net10.0-windows und net11.0-windows. Visual Studio 2026 baut net11.0-windows nur, wenn ein .NET 11 SDK unter `%ProgramFiles%\dotnet\sdk` installiert ist.
- Dev-Builds warnen, falls `..\Standard-Toolkit` fehlt.

---

## Español

### Descripción

- Script: `build-all.cmd`
- Objetivo: Compilar todas las soluciones (NuGet y Dev) con MSBuild, salida mínima en consola y generación de binlogs.

### Requisitos

- Visual Studio 2022 (cualquier edición) o VS 2022 Build Tools. Visual Studio 2026 es opcional para compilaciones net10.0/net11.0.
- SDKs de .NET necesarios (p. ej., net8.0, net9.0, net10.0, net11.0).
- Para soluciones Dev: repo hermano `..\Standard-Toolkit` en la rama correspondiente.

### Uso

```sh
build-all.cmd [Configuration] [Mode] [Rebuild] [Toolset]
```

- Configuration: `Debug` o `Release` (por defecto: `Release`)
- Mode: `all` | `nuget` | `dev` (por defecto: `all`)
- Rebuild: `on` | `off` (por defecto: `on`); `on` restaura todas las soluciones seleccionadas, borra una vez los directorios de salida de compilación y luego las compila; `off` usa `/restore` y `/t:Build`.
- Toolset: `2022` | `2026` | `auto` (por defecto: `2022`)
- Selectores de grupo de proyectos: `[Configuration] nuget off` omite soluciones NuGet; `[Configuration] dev off` omite soluciones Dev.
- Los archivos de solución específicos de configuración se filtran: `Release` omite soluciones `(Debug)` y `Debug` omite soluciones `(Release)`.

### Ejemplos

- Todo en Release con Rebuild (por defecto):

```sh
build-all.cmd
```

- Solo NuGet, Debug, sin Rebuild (incremental):

```sh
build-all.cmd Debug nuget on off
```

- Solo Dev, Release, con Rebuild:

```sh
build-all.cmd Release dev on
```

- Forzar VS 2022; se omiten net10.0-windows y net11.0-windows:

```sh
build-all.cmd Release all on 2022
```

- Omitir soluciones NuGet y compilar solo soluciones Dev:

```sh
build-all.cmd Debug nuget off
```

### Salida y logs

- Binlogs: `Binaries\BuildLogs\<solution-name>.rebuild.binlog` o `Binaries\BuildLogs\<solution-name>.build.binlog`
- Fallos: `Binaries\BuildLogs\_failed.txt` (se imprime al final si existe)
- Consola: silenciosa con resumen y marcas de tiempo
- Las soluciones se compilan con un solo nodo de MSBuild para evitar bloqueos de copia en la salida compartida.

### Ver .binlog

- Visor recomendado: MSBuild Structured Log Viewer (`https://msbuildlog.com`).
- O abrir `.binlog` directamente en Visual Studio (Archivo → Abrir → Archivo).

### Notas

- El toolset predeterminado es Visual Studio 2022. Toolset `2026` selecciona Visual Studio 2026 explícitamente, y `auto` prueba Visual Studio 2022 antes que Visual Studio 2026.
- Las compilaciones con Visual Studio 2022 omiten net10.0-windows y net11.0-windows. Visual Studio 2026 compila net11.0-windows solo si hay un SDK de .NET 11 instalado en `%ProgramFiles%\dotnet\sdk`.
- Los builds Dev avisan si falta `..\Standard-Toolkit`.

---

## 中文（简体）

### 概述

- 脚本：`build-all.cmd`
- 作用：使用 MSBuild 构建仓库内所有解决方案（NuGet 与 Dev），控制台输出精简，并生成 binlog。

### 前置条件

- 需要 Visual Studio 2022（任意版本）或 VS 2022 Build Tools。Visual Studio 2026 可选，用于 net10.0/net11.0 构建。
- 安装所需的 .NET SDK（如 net8.0、net9.0、net10.0、net11.0）。
- 对于 Dev 解决方案：需要同级目录下的 `..\Standard-Toolkit` 仓库（分支需匹配）。

### 用法

```sh
build-all.cmd [Configuration] [Mode] [Rebuild] [Toolset]
```

- Configuration：`Debug` 或 `Release`（默认：`Release`）
- Mode：`all` | `nuget` | `dev`（默认：`all`）
- Rebuild：`on` | `off`（默认：`on`）；`on` 会还原所有选中的解决方案，清空一次构建输出目录，然后进行构建；`off` 使用 `/restore` 和 `/t:Build`。
- Toolset：`2022` | `2026` | `auto`（默认：`2022`）
- 项目组开关：`[Configuration] nuget off` 跳过 NuGet 解决方案；`[Configuration] dev off` 跳过 Dev 解决方案。
- 会过滤带配置名称的解决方案文件：`Release` 跳过 `(Debug)` 解决方案，`Debug` 跳过 `(Release)` 解决方案。

### 示例

- 使用默认设置（Release + Rebuild）：

```sh
build-all.cmd
```

- 仅构建 NuGet，Debug，增量构建：

```sh
build-all.cmd Debug nuget on off
```

- 仅构建 Dev，Release，强制重建：

```sh
build-all.cmd Release dev on
```

- 强制使用 VS 2022；会跳过 net10.0-windows 和 net11.0-windows：

```sh
build-all.cmd Release all on 2022
```

- 跳过 NuGet 解决方案，仅构建 Dev 解决方案：

```sh
build-all.cmd Debug nuget off
```

### 输出与日志

- Binlog：`Binaries\BuildLogs\<solution-name>.rebuild.binlog` 或 `Binaries\BuildLogs\<solution-name>.build.binlog`
- 失败清单：`Binaries\BuildLogs\_failed.txt`（若存在将于结束时打印）
- 控制台输出：安静模式，带摘要与时间戳
- 解决方案使用一个 MSBuild 节点构建，以避免共享输出目录中的复制锁定。

### 查看 .binlog

- 推荐：MSBuild Structured Log Viewer（`https://msbuildlog.com`）。
- 或在 Visual Studio 中直接打开 `.binlog`（文件 → 打开 → 文件）。

### 说明

- 默认 Toolset 是 Visual Studio 2022。Toolset `2026` 会显式选择 Visual Studio 2026，`auto` 会先尝试 Visual Studio 2022，再尝试 Visual Studio 2026。
- Visual Studio 2022 构建会跳过 net10.0-windows 和 net11.0-windows。Visual Studio 2026 仅在 `%ProgramFiles%\dotnet\sdk` 下安装了 .NET 11 SDK 时构建 net11.0-windows。
- Dev 构建会在缺少 `..\Standard-Toolkit` 时给出提示。
