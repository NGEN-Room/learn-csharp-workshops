# Module 5: Strings

In this module, you'll learn how to create, format, and manipulate strings in C# — one of the most common tasks in any program.

---

## 💡 What You'll Learn
- Declaring and combining strings
- String interpolation and formatting
- Common string methods
- Working with characters and substrings

---

## ✍️ Code Examples

### Declare and print a string
```csharp
string message = "Hello, world!";
Console.WriteLine(message);
```

### String interpolation
```csharp
string name = "Aria";
int level = 5;
Console.WriteLine($"Welcome, {name}. You are level {level}.");
```

### String methods
```csharp
string word = "CSharp";
Console.WriteLine(word.ToUpper());      // "CSHARP"
Console.WriteLine(word.ToLower());      // "csharp"
Console.WriteLine(word.Length);         // 6
Console.WriteLine(word.Contains("S"));  // true
```

---

## 🧠 Key Concepts

- `+` joins strings together
- Interpolation (`$"Hello, {name}!"`) is easier to read
- Strings are immutable — you create new ones when you change them
- Useful methods: `.ToUpper()`, `.ToLower()`, `.Length`, `.Substring()`, `.Contains()`, `.Replace()`

---

## 🎓 Extra Learning (Microsoft C# Training)

🔗 [Perform Basic String Formatting in C#](https://learn.microsoft.com/en-us/training/modules/csharp-basic-string-formatting/)  
🔗 [Modify String Content Using Built-in Methods](https://learn.microsoft.com/en-us/training/modules/csharp-string-methods/)

These go deeper into:
- How to format strings for output
- How to search, edit, and extract parts of a string

---

## ✅ Checklist

- [ ] I can use string interpolation
- [ ] I know at least 5 string methods
- [ ] I can combine and manipulate strings
- [ ] I explored the Microsoft Learn resources
