# Project – GameObject Inspector

## 🧠 Goal:
Use the base `object` class to simulate a game-like object inspector that can print and compare various data types.

---

## 🔧 Instructions:
1. Create several classes: `Player`, `Enemy`, `Item`
   - Give each a `Name` and override `ToString()`
   - Optionally override `Equals()` to compare objects

2. Create a method `InspectObject(object obj)` that:
   - Prints `obj.ToString()`
   - Prints `obj.GetType()`
   - Prints `obj.GetHashCode()`

3. Call `InspectObject()` on different types (custom classes, strings, ints)

---

## 🧪 Example Output:
```
[Player: Riko]
Type: Player
HashCode: 60392183
```

---

## ✅ Bonus Challenges:
- Use a `List<object>` to store mixed types
- Create a loop to inspect them all
- Compare two objects and explain the output

---

## 🛠 How To Start

Create a new console app:
```bash
dotnet new console -o GameObjectInspector
cd GameObjectInspector
```

Write your code in `Program.cs` and run:
```bash
dotnet run
```
