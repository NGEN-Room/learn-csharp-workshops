# 03 Data Types and Variables

## Lesson Content

- [ ] Add lesson notes here.
# Module 3: Data Types and Variables

In this module, you'll learn how to store and manage data using variables and data types in C#.

---

## 💡 What You'll Learn
- The purpose of variables
- Common C# data types: `int`, `double`, `string`, `bool`, `char`
- How to declare and initialize variables
- Naming conventions and best practices

---

## ✍️ Code Examples

### Declare a variable
```csharp
int age = 25;
string name = "Piha";
bool isRaining = false;
```

### Print them to the console
```csharp
Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
```

---

## 🧠 Key Concepts

| Data Type | Description                  | Example          |
|-----------|------------------------------|------------------|
| `int`     | Whole numbers                 | `int score = 42;`|
| `double`  | Decimal numbers               | `double pi = 3.14;` |
| `string`  | Text                          | `string name = "Ana";` |
| `bool`    | True/False values             | `bool active = true;` |
| `char`    | Single character              | `char grade = 'A';` |

---

## 🎓 Extra Learning (Microsoft C# Training)

To go further with variables and data types, check out:
🔗 [Store and Retrieve Data Using Literal and Variable Values in C#](https://learn.microsoft.com/en-us/training/modules/csharp-write-first/2-literals-variables)  
🔗 [Choose the Correct Data Type in Your C# Code](https://learn.microsoft.com/en-us/training/modules/csharp-work-with-variable-data/2-choose-correct-data-type)

These cover:
- Literal values and how they’re used
- More details on data types and casting
- Examples of how to convert or store values safely

---

## ✨ Real-World Tip from Microsoft Learn:
> “Variables are the names you assign to computer memory locations that hold your program’s data.”

This means variables act like *labels on boxes* in memory. If you name it `playerScore`, it makes your program easier to read — and change later.

You can also *explicitly cast* values:
```csharp
double score = 88.6;
int roundedScore = (int)score; // result: 88
```

---

## ✅ Checklist

- [ ] I can declare a variable
- [ ] I understand the difference between data types
- [ ] I can output variable values to the console
- [ ] I explored the Microsoft Learn extras!
