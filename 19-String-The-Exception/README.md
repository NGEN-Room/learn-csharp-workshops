# Module 19: String & Exceptions

In this module, you'll learn more about working with strings and handling errors using exceptions in C#.

---

## 💡 What You'll Learn
- Advanced string methods and formatting
- Common pitfalls with string handling
- How to use `try`, `catch`, `finally`
- How to throw and catch exceptions properly

---

## ✍️ Code Examples

### String formatting and manipulation
```csharp
string name = " Piha ";
Console.WriteLine(name.Trim());         // "Piha"
Console.WriteLine(name.ToUpper());      // " PIHA "
Console.WriteLine(name.Contains("i"));  // true
```

### Try-catch block
```csharp
try
{
    int x = int.Parse("not-a-number");
}
catch (FormatException ex)
{
    Console.WriteLine("Invalid number!");
}
finally
{
    Console.WriteLine("Attempted to parse input.");
}
```

---

## 🧠 Key Concepts

- Use `.Trim()`, `.Split()`, `.Replace()`, `.Contains()` for powerful string manipulation
- Use `try`/`catch` to handle runtime errors safely
- `finally` always runs (even after exceptions)
- You can throw your own exceptions using `throw new Exception("Message")`

---

## 🎓 Extra Learning (Microsoft C# Training)

🔗 [Handle Errors in C# Using Try, Catch, and Finally](https://learn.microsoft.com/en-us/training/modules/csharp-handle-errors/)  
🔗 [Modify String Content Using Built-in Methods](https://learn.microsoft.com/en-us/training/modules/csharp-string-methods/)

---

## ✅ Checklist

- [ ] I can safely handle runtime errors with try/catch
- [ ] I know how to throw and catch exceptions
- [ ] I explored advanced string functions
- [ ] I explored the Microsoft Learn modules
