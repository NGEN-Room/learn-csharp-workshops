# Project – Interactable System

## 🧠 Goal:
Use interfaces to define common behaviors across different interactable objects in a game-like environment.

---

## 🔧 Instructions:
1. Create an interface `IInteractable` with a method `Interact()`
2. Create 3 classes that implement `IInteractable`:
   - `Chest` → prints “You opened a chest and found gold.”
   - `Door` → prints “You opened the door.”
   - `SignPost` → prints “The sign reads: Welcome to NGEN!”

3. In `Main`, store them in a `List<IInteractable>` and loop through calling `Interact()`

---

## 🧪 Example Output:
```
You opened a chest and found gold.
You opened the door.
The sign reads: Welcome to NGEN!
```

---

## ✅ Bonus Challenges:
- Add a `Name` property to each object
- Add a method `Examine()` to print object details
- Let users type `interact` or `examine` in a menu

---

## 🛠 How To Start

Create a new console app:
```bash
dotnet new console -o InteractableSystem
cd InteractableSystem
```

Write your code in `Program.cs` and run:
```bash
dotnet run
```
