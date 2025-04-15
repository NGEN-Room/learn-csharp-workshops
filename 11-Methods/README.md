# Module 11: Methods

In this module, you'll learn how to define and use methods — reusable blocks of code that make programs cleaner and more organized.

---

## 💡 What You'll Learn
- How to declare and call a method
- How to pass parameters and return values
- Method scope and structure
- Best practices for naming and organizing

---

## ✍️ Code Examples

### Define and call a method
```csharp
void SayHello()
{
    Console.WriteLine("Hello!");
}

SayHello();
```

### Method with parameters and return
```csharp
int Add(int a, int b)
{
    return a + b;
}

int result = Add(3, 5);  // result = 8
```

---

## 🧠 Key Concepts

- Methods let you reuse code
- Use parameters to pass data in, and `return` to pass data out
- Methods should do one thing clearly and well
- You can overload methods with different parameter types

---

## 🎓 Extra Learning (Microsoft C# Training)

🔗 [Write C# Methods That Return a Value](https://learn.microsoft.com/en-us/training/modules/csharp-write-methods-return-value/)  
🔗 [Write and Call C# Methods That Take Parameters](https://learn.microsoft.com/en-us/training/modules/csharp-methods-parameters/)

---

## ✅ Checklist

- [ ] I can create and call methods
- [ ] I know how to return values and pass parameters
- [ ] I understand scope and reuse
- [ ] I explored the Microsoft Learn modules
