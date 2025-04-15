# Project – Game Settings Manager

## 🧠 Goal:
Create a settings manager using encapsulation to control how players adjust game options.

---

## 🔧 Instructions:
1. Create a class `GameSettings` with the following:
   - Private fields: `volume`, `brightness`
   - Public properties with validation:
     - `Volume` (0–100)
     - `Brightness` (0.0–1.0)

2. Add a method `DisplaySettings()` that prints the current values

3. In `Main`, create a settings instance and let the user input values.
   - Reject out-of-range values using property validation

---

## 🧪 Example Output:
```
Enter volume (0–100):
> 110
Invalid volume!

Enter brightness (0.0–1.0):
> 0.8
Settings:
Volume: 75
Brightness: 0.8
```

---

## ✅ Bonus Challenges:
- Add a mute toggle (`bool IsMuted`)
- Add a method `ApplyDefaults()` that resets all settings
- Create a simple menu to interactively test different inputs

---

## 🛠 How To Start

Create a new console app:
```bash
dotnet new console -o GameSettingsManager
cd GameSettingsManager
```

Write your code in `Program.cs` and run:
```bash
dotnet run
```
