# Module 7: Conditionals

This module dives into `if`, `else if`, `else`, and `switch` statements — the foundation of decision-making in C#.

---

## 💡 What You'll Learn
- How to control flow using `if`, `else if`, and `else`
- How to use `switch` statements
- How to use nested and combined conditionals
- How to organize logic for readability

---

## ✍️ Code Examples

### Basic conditional
```csharp
int score = 85;
if (score >= 90)
{
    Console.WriteLine("A");
}
else if (score >= 80)
{
    Console.WriteLine("B");
}
else
{
    Console.WriteLine("Needs work.");
}
```

### Switch statement
```csharp
string choice = "yes";

switch (choice)
{
    case "yes":
        Console.WriteLine("Confirmed.");
        break;
    case "no":
        Console.WriteLine("Cancelled.");
        break;
    default:
        Console.WriteLine("Invalid input.");
        break;
}
```

---

## 🧠 Key Concepts

- Use `if` when you have one or more conditions to check
- `else` handles fallback logic
- `switch` is great for checking against multiple exact values
- Always include a `default` case in `switch`

---

## 🎓 Extra Learning (Microsoft C# Training)

🔗 [Add Decision Logic to Your C# Code Using the if, else, and else if Statements](https://learn.microsoft.com/en-us/training/modules/csharp-add-logic-if-elseif-else/)  
🔗 [Use the switch-case Construct](https://learn.microsoft.com/en-us/training/modules/csharp-switch-case/)

---

## ✅ Checklist

- [ ] I can write basic if/else logic
- [ ] I know how to use a switch statement
- [ ] I understand when to use `else if` vs `switch`
- [ ] I explored the Microsoft Learn resources
