# Module 14: Inheritance

In this module, you'll learn how to reuse and extend class functionality using inheritance — a key principle of object-oriented programming.

---

## 💡 What You'll Learn
- What inheritance is and why it’s useful
- How to create base and derived classes
- How to override and extend class behavior
- The `base` and `virtual/override` keywords

---

## ✍️ Code Examples

### Base and derived class
```csharp
public class Animal
{
    public string Name;

    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine($"{Name} says Woof!");
    }
}
```

### Using inheritance
```csharp
Dog d = new Dog();
d.Name = "Rex";
d.Speak();  // Rex says Woof!
```

---

## 🧠 Key Concepts

- Inheritance lets one class **extend** another
- Use `: BaseClass` to create a derived class
- Mark methods as `virtual` in the base, and `override` in the derived class
- Use `base` to access the parent class

---

## 🎓 Extra Learning (Microsoft C# Training)

🔗 [Use Inheritance to Create a Family of Related Classes](https://learn.microsoft.com/en-us/training/modules/csharp-inheritance/)

This module covers:
- Reuse of class code
- Overriding functionality
- Organizing shared behaviors

---

## ✅ Checklist

- [ ] I can create a base class and derived class
- [ ] I know how to override a method
- [ ] I understand when to use inheritance
- [ ] I explored the Microsoft Learn module
