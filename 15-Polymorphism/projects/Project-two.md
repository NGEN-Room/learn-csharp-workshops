# Project – Ability System

## 🧠 Goal:
Use polymorphism to create a flexible system for triggering different abilities from multiple character types.

---

## 🔧 Instructions:
1. Create a base class `Ability` with a method `Activate()`
2. Create at least three derived classes:
   - `HealAbility` → prints “Casting heal...”
   - `FireballAbility` → prints “Throwing fireball!”
   - `StealthAbility` → prints “Entering stealth...”

3. In `Main`, store these abilities in a `List<Ability>` and loop through them calling `Activate()`

---

## 🧪 Example Output:
```
Casting heal...
Throwing fireball!
Entering stealth...
```

---

## ✅ Bonus Challenges:
- Add a `Name` property to each ability
- Randomly trigger abilities from the list
- Add a `Cooldown` field and method `IsAvailable()`

---

## 🛠 How To Start

Create a new console app:
```bash
dotnet new console -o AbilitySystem
cd AbilitySystem
```

Write your code in `Program.cs` and run:
```bash
dotnet run
```
