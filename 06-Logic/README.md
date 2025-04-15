# Module 6: Logic

In this module, you'll learn how to use logical expressions and boolean values to control program behavior.

---

## 💡 What You'll Learn
- Boolean logic and comparison operators
- Logical operators: `&&`, `||`, `!`
- How to use logic in decision-making
- How to read and build compound conditions

---

## ✍️ Code Examples

### Comparison operators
```csharp
int a = 5;
int b = 10;
Console.WriteLine(a < b);   // true
Console.WriteLine(a == b);  // false
Console.WriteLine(a != b);  // true
```

### Logical operators
```csharp
bool isRaining = true;
bool hasUmbrella = false;

if (isRaining && !hasUmbrella)
{
    Console.WriteLine("You might get wet!");
}
```

### Combining conditions
```csharp
int age = 20;
if (age > 18 && age < 65)
{
    Console.WriteLine("You are an adult of working age.");
}
```

---

## 🧠 Key Concepts

- Boolean values are either `true` or `false`
- `&&` = AND, `||` = OR, `!` = NOT
- Use logic to decide *when* to run code
- Group conditions with parentheses for clarity

---

## 🎓 Extra Learning (Microsoft C# Training)

🔗 [Evaluate Boolean Expressions to Make Decisions](https://learn.microsoft.com/en-us/training/modules/csharp-evaluate-boolean-expressions/)

This module helps you:
- Understand how conditionals work in real-world apps
- Chain conditions together
- Use logic to drive application flow

---

## ✅ Checklist

- [ ] I understand how boolean values work
- [ ] I can use comparison and logical operators
- [ ] I can build compound conditions
- [ ] I explored the Microsoft Learn training
