# Project – Dialogue Parser

## 🧠 Goal:
Simulate a dialogue system that loads lines and handles bad input using exceptions and string methods.

---

## 🔧 Instructions:
1. Store an array or list of dialogue strings
2. Create a method `PrintLine(int index)` that:
   - Prints the line if it exists
   - Catches `IndexOutOfRangeException` and prints an error

3. In `Main`, ask the user which line to display using input

---

## 🧪 Example Output:
```
Enter line number to read:
> 3
"Welcome to the world of NGEN."

> 10
Error: No dialogue found for that line.
```

---

## ✅ Bonus Challenges:
- Clean user input with `.Trim()`, `.ToLower()`, etc.
- Use a loop to allow multiple attempts
- Add a catch for `FormatException` if non-numeric input is entered

---

## 🛠 How To Start

Create a new console app:
```bash
dotnet new console -o DialogueParser
cd DialogueParser
```

Write your code in `Program.cs` and run:
```bash
dotnet run
```
