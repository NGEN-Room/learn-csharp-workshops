# Project – Enemy Types System

## 🧠 Goal:
Use inheritance to create different types of enemies in a basic game simulation.

---

## 🔧 Instructions:
1. Create a base class `Enemy` with:
   - Fields: `Name`, `Health`
   - Method: `TakeDamage(int amount)` that lowers health

2. Create derived classes:
   - `Goblin`: overrides `TakeDamage()` to reduce damage taken by 10%
   - `Orc`: overrides `TakeDamage()` to print a custom reaction

3. In `Main`, create a list of enemies and apply damage using a loop.

---

## 🧪 Example Output:
```
Goblin takes 9 damage (after reduction)
Orc grunts and takes 15 damage
```

---

## ✅ Bonus Challenges:
- Add a `DisplayStats()` method to all enemies
- Track if an enemy has been defeated (health <= 0)
- Add a method `Attack()` with different messages per enemy type

---

## 🛠 How To Start

Create a new console app:
```bash
dotnet new console -o EnemySystem
cd EnemySystem
```

Write your code in `Program.cs` and run:
```bash
dotnet run
```
