This guide includes sections in English, German, Spanish, and Simplified Chinese.

## English

### Overview
- Script: `build-all.cmd`
- Purpose: Build all solutions in this repo (NuGet- and Dev-based) with MSBuild, produce concise console output, and write binlogs.

### Prerequisites
- Visual Studio 2022 (any edition) or VS 2022 Build Tools (required).
- .NET SDKs: net8.0 and net9.0 as needed by solutions.
- For Dev solutions: sibling repo `..\Standard-Toolkit` on a matching branch.

### Usage
```
build-all.cmd [Configuration] [Mode] [Rebuild]
```
- Configuration: `Debug` or `Release` (default: `Release`)
- Mode: `all` | `nuget` | `dev` (default: `all`)
- Rebuild: `on` | `off` (default: `on`)

### Examples
- Build everything in Release with Rebuild (default):
```
build-all.cmd
```
- NuGet-only, Debug, Rebuild off (incremental):
```
build-all.cmd Debug nuget off
```
- Dev-only, Release, Rebuild on:
```
build-all.cmd Release dev on
```

### Output & Logs
- Binlogs: `Binaries\BuildLogs\<solution-name>.binlog`
- Failures summary: `Binaries\BuildLogs\_failed.txt` (printed at end if present)
- Console output: quiet with summary and timestamps

### Inspecting .binlog
- Recommended viewer: MSBuild Structured Log Viewer (`https://msbuildlog.com`).
- Or open `.binlog` directly in Visual Studio (File → Open → File).

### Notes
- Only Visual Studio 2022 installations are used; older MSBuild versions are ignored.
- Dev builds warn if `..\Standard-Toolkit` is not present.

---

## Deutsch

### Übersicht
- Skript: `build-all.cmd`
- Zweck: Alle Lösungen (NuGet und Dev) mit MSBuild bauen, konsolen­ausgabe minimieren, Binlogs schreiben.

### Voraussetzungen
- Visual Studio 2022 (beliebige Edition) oder VS 2022 Build Tools.
- Erforderliche .NET SDKs (z. B. net8.0, net9.0).
- Für Dev-Lösungen: Neben-Repo `..\Standard-Toolkit` auf passendem Branch.

### Verwendung
```
build-all.cmd [Configuration] [Mode] [Rebuild]
```
- Configuration: `Debug` oder `Release` (Standard: `Release`)
- Mode: `all` | `nuget` | `dev` (Standard: `all`)
- Rebuild: `on` | `off` (Standard: `on`)

### Beispiele
- Alles in Release mit Rebuild (Standard):
```
build-all.cmd
```
- Nur NuGet, Debug, Rebuild aus (inkrementell):
```
build-all.cmd Debug nuget off
```
- Nur Dev, Release, Rebuild an:
```
build-all.cmd Release dev on
```

### Ausgaben & Logs
- Binlogs: `Binaries\BuildLogs\<solution-name>.binlog`
- Fehlerliste: `Binaries\BuildLogs\_failed.txt` (wird am Ende ausgegeben, falls vorhanden)
- Konsole: ruhig, mit Zusammenfassung und Zeitstempeln

### Binlog ansehen
- Empfohlen: MSBuild Structured Log Viewer (`https://msbuildlog.com`).
- Alternativ: `.binlog` direkt in Visual Studio öffnen (Datei → Öffnen → Datei).

### Hinweise
- Es wird ausschließlich VS 2022 verwendet; ältere MSBuild-Versionen werden ignoriert.
- Dev-Builds warnen, falls `..\Standard-Toolkit` fehlt.

---

## Español

### Descripción
- Script: `build-all.cmd`
- Objetivo: Compilar todas las soluciones (NuGet y Dev) con MSBuild, salida mínima en consola y generación de binlogs.

### Requisitos
- Visual Studio 2022 (cualquier edición) o VS 2022 Build Tools.
- SDKs de .NET necesarios (p. ej., net8.0, net9.0).
- Para soluciones Dev: repo hermano `..\Standard-Toolkit` en la rama correspondiente.

### Uso
```
build-all.cmd [Configuration] [Mode] [Rebuild]
```
- Configuration: `Debug` o `Release` (por defecto: `Release`)
- Mode: `all` | `nuget` | `dev` (por defecto: `all`)
- Rebuild: `on` | `off` (por defecto: `on`)

### Ejemplos
- Todo en Release con Rebuild (por defecto):
```
build-all.cmd
```
- Solo NuGet, Debug, sin Rebuild (incremental):
```
build-all.cmd Debug nuget off
```
- Solo Dev, Release, con Rebuild:
```
build-all.cmd Release dev on
```

### Salida y logs
- Binlogs: `Binaries\BuildLogs\<solution-name>.binlog`
- Fallos: `Binaries\BuildLogs\_failed.txt` (se imprime al final si existe)
- Consola: silenciosa con resumen y marcas de tiempo

### Ver .binlog
- Visor recomendado: MSBuild Structured Log Viewer (`https://msbuildlog.com`).
- O abrir `.binlog` directamente en Visual Studio (Archivo → Abrir → Archivo).

### Notas
- Solo se usa VS 2022; se ignoran versiones anteriores de MSBuild.
- Los builds Dev avisan si falta `..\Standard-Toolkit`.

---

## 中文（简体）

### 概述
- 脚本：`build-all.cmd`
- 作用：使用 MSBuild 构建仓库内所有解决方案（NuGet 与 Dev），控制台输出精简，并生成 binlog。

### 前置条件
- 必须安装 Visual Studio 2022（任意版本）或 VS 2022 Build Tools。
- 安装所需的 .NET SDK（如 net8.0、net9.0）。
- 对于 Dev 解决方案：需要同级目录下的 `..\Standard-Toolkit` 仓库（分支需匹配）。

### 用法
```
build-all.cmd [Configuration] [Mode] [Rebuild]
```
- Configuration：`Debug` 或 `Release`（默认：`Release`）
- Mode：`all` | `nuget` | `dev`（默认：`all`）
- Rebuild：`on` | `off`（默认：`on`）

### 示例
- 使用默认设置（Release + Rebuild）：
```
build-all.cmd
```
- 仅构建 NuGet，Debug，增量构建：
```
build-all.cmd Debug nuget off
```
- 仅构建 Dev，Release，强制重建：
```
build-all.cmd Release dev on
```

### 输出与日志
- Binlog：`Binaries\BuildLogs\<solution-name>.binlog`
- 失败清单：`Binaries\BuildLogs\_failed.txt`（若存在将于结束时打印）
- 控制台输出：安静模式，带摘要与时间戳

### 查看 .binlog
- 推荐：MSBuild Structured Log Viewer（`https://msbuildlog.com`）。
- 或在 Visual Studio 中直接打开 `.binlog`（文件 → 打开 → 文件）。

### 说明
- 仅使用 VS 2022；旧版 MSBuild 将被忽略。
- Dev 构建会在缺少 `..\Standard-Toolkit` 时给出提示。
