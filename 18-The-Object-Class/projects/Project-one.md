# Project – Object Inspector

## 🧠 Goal:
Create a utility that uses the `object` class methods to explore different data.

## 🔧 Instructions:
1. Create a method `Inspect(object item)` that:
   - Prints `item.ToString()`
   - Prints `item.GetType()`
   - Optionally shows `item.GetHashCode()`
2. Call this method with different data types (int, string, custom class)

## ✅ Bonus Challenge:
- Create a custom class and override `ToString()`
- Use a loop to inspect a list of mixed objects

---

## 🛠️ How To Start

Create a new console app:
```bash
dotnet new console -o ObjectInspector
cd ObjectInspector
```

Write your code in `Program.cs` and run:
```bash
dotnet run
```
