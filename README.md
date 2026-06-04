# UncappedCombo

Trombone Champ Mod: Removes combo cap for ScorePopups.

Trombone Champ Modding Discord: https://discord.gg/KVzKRsbetJ

---

## Installation

1. Install **BepInEx** for Trombone Champ
2. Download the latest release from GitHub
3. Extract the zip
4. Copy `UncappedCombo.dll` into: `BepInEx/plugins/`
5. Launch the game


## Build from source

1. Create a `lib/` folder in the project directory
2. Copy these from `TromboneChamp_Data/Managed` and you profile folder:
- 0Harmony.dll
- BepInEx.dll
- Assembly-CSharp.dll
- UnityEngine.dll
- UnityEngine.CoreModule.dll
- UnityEngine.UI.dll
- UniteEngine.TextRenderingModule.dll

3. Build using:

```bash
dotnet build -c Release
```

4. Output located at `bin/Release/net472/UncappedCombo.dll`
