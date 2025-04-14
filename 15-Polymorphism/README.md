# Module 15: Polymorphism

In this module, you'll learn how polymorphism lets you treat different object types through a common interface or base class.

---

## 💡 What You'll Learn
- What polymorphism means in C#
- How to use overridden methods in a consistent way
- The role of base class references and method overriding
- How polymorphism enables flexible, scalable code

---

## ✍️ Code Examples

### Polymorphism in action
```csharp
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks.");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow.");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof.");
    }
}
```

### Using polymorphism
```csharp
List<Animal> animals = new List<Animal> { new Dog(), new Cat() };

foreach (Animal a in animals)
{
    a.Speak();  // Each one calls its own version of Speak()
}
```

---

## 🧠 Key Concepts

- Polymorphism = “many forms”
- Base class references can point to derived class objects
- Overridden methods allow objects to behave differently, even when accessed generically
- Encourages reusable, decoupled code

---

## 🎓 Extra Learning (Microsoft C# Training)

🔗 [Use Polymorphism to Write More Flexible and Reusable Code](https://learn.microsoft.com/en-us/training/modules/csharp-polymorphism/)

---

## ✅ Checklist

- [ ] I understand what polymorphism is
- [ ] I can override methods and use base class references
- [ ] I know how polymorphism supports code flexibility
- [ ] I explored the Microsoft Learn module
