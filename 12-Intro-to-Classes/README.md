# Module 12: Intro to Classes

In this module, you'll learn how to define your own types using classes — the core building blocks of object-oriented programming in C#.

---

## 💡 What You'll Learn
- What a class is and why it’s used
- How to define a class with fields and methods
- How to create objects (instances) of a class
- Constructors and basic encapsulation

---

## ✍️ Code Examples

### Define a class
```csharp
public class Person
{
    public string Name;
    public int Age;

    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
    }
}
```

### Create an object and use it
```csharp
Person p = new Person();
p.Name = "Piha";
p.Age = 32;
p.Introduce();
```

### Constructor
```csharp
public Person(string name, int age)
{
    Name = name;
    Age = age;
}
```

---

## 🧠 Key Concepts

- A **class** is like a blueprint; an **object** is a real thing built from it
- You can define data (fields/properties) and behavior (methods)
- Use `new` to create an instance (object)
- Constructors help set up objects with initial values

---

## 🎓 Extra Learning (Microsoft C# Training)

🔗 [Create and Use Classes in C#](https://learn.microsoft.com/en-us/training/modules/csharp-create-use-classes/)

This module covers:
- Creating types
- Instantiating and using objects
- Separating logic into reusable components

---

## ✅ Checklist

- [ ] I can define a class with properties and methods
- [ ] I know how to create objects
- [ ] I can use constructors
- [ ] I explored the Microsoft Learn module
