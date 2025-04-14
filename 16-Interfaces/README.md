# Module 16: Interfaces

In this module, you'll learn how to define and implement interfaces — contracts that help organize and enforce behavior across different classes.

---

## 💡 What You'll Learn
- What an interface is and how it's used
- How to implement interfaces in classes
- How interfaces support polymorphism and design
- Real-world uses of interfaces

---

## ✍️ Code Examples

### Define and use an interface
```csharp
public interface IPlayable
{
    void Play();
}

public class Music : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Playing music...");
    }
}

public class Video : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Playing video...");
    }
}
```

### Using the interface
```csharp
List<IPlayable> items = new List<IPlayable> { new Music(), new Video() };

foreach (IPlayable item in items)
{
    item.Play();  // Each calls its own implementation
}
```

---

## 🧠 Key Concepts

- An **interface** defines a contract (what a class *must* do)
- Classes that implement an interface must provide the method(s)
- Use interfaces for loose coupling and flexible code
- Common naming: interface starts with "I" (e.g., `IDisposable`, `IComparable`)

---

## 🎓 Extra Learning (Microsoft C# Training)

🔗 [Define and Implement Interfaces in C#](https://learn.microsoft.com/en-us/training/modules/csharp-interfaces/)

---

## ✅ Checklist

- [ ] I understand what an interface is
- [ ] I can implement interfaces in multiple classes
- [ ] I know how interfaces support polymorphism
- [ ] I explored the Microsoft Learn module
