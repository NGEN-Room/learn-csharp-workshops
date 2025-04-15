# Project – Quest Log Filter

## 🧠 Goal:
Use LINQ to manage and search a game-style quest log with filtering and projection.

---

## 🔧 Instructions:
1. Create a `Quest` class with:
   - `Title`, `IsCompleted`, `Difficulty` (Easy/Medium/Hard)

2. Create a list of quests with various properties

3. Use LINQ to:
   - Show all uncompleted quests
   - Group quests by difficulty
   - Show only quest titles using `.Select()`

---

## 🧪 Example Output:
```
Uncompleted Quests:
- Find the Staff
- Rescue the Villager

Grouped by Difficulty:
Easy: 2 quests
Medium: 1 quest
Hard: 1 quest
```

---

## ✅ Bonus Challenges:
- Add a method to mark a quest as completed
- Create a basic menu system to show filtered views
- Allow user input to search for a quest by keyword

---

## 🛠 How To Start

Create a new console app:
```bash
dotnet new console -o QuestLogLINQ
cd QuestLogLINQ
```

Write your code in `Program.cs` and run:
```bash
dotnet run
```
