# Module 10: Lists

In this module, you’ll learn how to work with dynamic collections using `List<T>` in C#.

---

## 💡 What You'll Learn
- How to create and use `List<T>`
- Adding, removing, and updating elements
- Iterating through a list
- Checking if items exist and finding indexes

---

## ✍️ Code Examples

### syntax
```csharp
List<int> numbers = new List<int> {1,2,3};
numbers.add(4)
```

### Create a list
```csharp
List<string> groceries = new List<string>();
groceries.Add("Milk");
groceries.Add("Eggs");
```

### Loop through a list
```csharp
foreach (string item in groceries)
{
    Console.WriteLine(item);
}
```

### Remove and check
```csharp
groceries.Remove("Eggs");
bool hasMilk = groceries.Contains("Milk");
int index = groceries.IndexOf("Milk");
```

---

## 🧠 Key Concepts

- `List<T>` is a resizable array-like collection
- Use `.Add()`, `.Remove()`, `.Clear()`, `.Count`, `.Contains()`, `.IndexOf()`
- Lists are part of `System.Collections.Generic`

---

## 🎓 Extra Learning (Microsoft C# Training)

🔗 [Perform Operations on a List Using Helper Methods](https://learn.microsoft.com/en-us/training/modules/csharp-list-operations/)

Covers:
- Managing items in a dynamic collection
- Using helpful built-in methods
- Searching, filtering, and modifying lists

---

## ✅ Checklist

- [ ] I can create and loop through a list
- [ ] I know how to add and remove items
- [ ] I explored the Microsoft Learn module
