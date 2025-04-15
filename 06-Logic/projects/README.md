# Project – Access Checker

## 🧠 Goal:
Write a program that checks whether a person should be granted access based on age and ticket status.

## 🔧 Requirements:
1. Ask the user for their age
2. Ask if they have a valid ticket (yes/no)
3. Grant access if age is over 16 AND they have a ticket

## 🧪 Example Output:
```
Enter your age:
> 17
Do you have a valid ticket? (yes/no)
> yes
Access granted!
```

## ✅ Bonus Challenge:
- Convert the ticket answer to lowercase
- Use `||` to allow access for VIPs regardless of age

---

## 🛠️ How To Start

Create a new console app:
```bash
dotnet new console -o AccessChecker
cd AccessChecker
```

Write your code in `Program.cs` and run:
```bash
dotnet run
```
