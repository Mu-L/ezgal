<div align="center" style="display:grid;place-items:center;">
<p>
    <a href="https://gitee.com/cryingn/ezgal" target="_blank"><img width="180" src="./ezgal/image/icon.png" alt="ezgal logo"></a>
<h1>ezgal</h1>
</p>
</div>

English|[中文](./README_CN.md)

This is a framework based on godot.mono designed to facilitate galgame development.

![](./image/image.png)

## Description

We initially implemented the ezgal framework for Godot3 in November 2023, but discontinued maintenance due to scalability issues. The engine was subsequently rewritten. Here are the features of the new ezgal framework:

| Description       | ezgal                                                                              | Contributor     |
| ----------------- | ---------------------------------------------------------------------------------- | --------------- |
| Godot Version     | Godot4 (with ongoing compatibility considerations)                                 | cryingn         |
| Programming Language | C#                                                                                 | cryingn         |
| Development Modes | Supports two modes: [Deep Integration](#deep-integration) for single-file packaging with extended features, and [Low-Code Development](#low-code-development) enabling direct script editing via APIs | cryingn         |
| ezgal Interpreter | Parses scenario files into JSON format and processes them segment by segment        | cryingn         |
| Script Syntax     | Separates dialogue writing from scene direction for clear role differentiation     | cryingn         |

## Usage

### Deep Integration

Clone the source code into your project and import the **ezgal** folder into Godot:

```bash
git clone https://gitee.com/cryingn/ezgal
cd ezgal/ezgal

To package into a single executable, compile using the make folder into ./ezgal/code/FlowData.cs. Due to dotnet/mono differences across systems, follow these guidelines:
Windows

Packaging command:

bash

dotnet run --project make

To revert to editable mode:

bash

dotnet run --project make test

Linux

Tested working on Arch Linux with godot-mono. Requires separate mono installation. Compile make tool first:

bash

mcs make/make.cs

Then package with:

bash

./make/make

Revert to editable mode:

bash

./make/make test

Low-Code Development

(Future mainstream development method - modify external folders for script/character art/dictionary/music editing)

Post-compilation, directly edit external folder contents for resource modification.
Syntax

For intuitive scriptwriting, dialogue and scene direction are separated. Detailed below:
Dialogue

Dialogue Box format:

[对话框]
This demonstrates dialogue box display
Girl: This is how a character speaks in dialogue boxes

Fullscreen format:

[全屏]
Fullscreen supports multi-line content
But no character speaking
Supports up to 12 simultaneous lines
[全屏]
Redefine to switch line count early

Options share formatting with Dialogue/Fullscreen but store choices for player selection:

[选项]
{script:测试3.txt}Jump to Test3
{jump:循环1}Jump to Loop1
Continue
[全屏]
You'll see this after selecting fullscreen

BBCode supported for formatting. Define terms like:

[全屏]
This is a [url=专业名词]professional term[/url]

Selecting terms triggers dictionary popups. Define terms in dictionary folder via 专业名词.txt.
Scene Direction

Use @ to mark jump points:

@循环1
This creates an infinite loop
{jump:循环1}

All scene commands use braces:

{bg:封面.png}  // Change background
{少女:normal.png-1200x650-1.1}Girl: Hello everyone  // Set character art
{script:测试2.txt, jump:循环1}  // Jump to specific script position

Command parameters explained:
Parameter	Description	Example
bg	Background images (stored in ./image/background/)	bg:封面.png
script	Jump to specified script file	script:测试3.txt
jump	Jump to marked position (@ symbol)	jump:循环1
ef	Reserved for future special effects	(Not yet implemented)
[default]	Character art configuration (files in ./image/ with naming [name]-[height]x[width]-[scale])	少女:normal.png-1200x650-1.1


