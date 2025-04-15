# Module 20: LINQ

In this final module, you’ll learn how to use LINQ (Language Integrated Query) to filter, search, and transform data collections in C#.

---

## 💡 What You'll Learn
- What LINQ is and why it’s powerful
- Common LINQ methods: `Where`, `Select`, `OrderBy`, `FirstOrDefault`
- Query vs method syntax
- Using LINQ with `List<T>`

---

## ✍️ Code Examples

### Method syntax
```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
var evens = numbers.Where(n => n % 2 == 0).ToList();
Console.WriteLine(string.Join(", ", evens));  // 2, 4
```

### Query syntax
```csharp
var query = from n in numbers
            where n > 3
            select n;

foreach (var n in query)
{
    Console.WriteLine(n);  // 4, 5
}
```

---

## 🧠 Key Concepts

- LINQ adds querying to C# directly
- Use `.Where()` to filter, `.Select()` to transform
- LINQ is most useful with `List<T>` and collections
- Query syntax is readable, method syntax is more flexible

---

## 🎓 Extra Learning (Microsoft C# Training)

🔗 [Query and Manipulate Data Using LINQ](https://learn.microsoft.com/en-us/training/modules/csharp-linq/)

---

## ✅ Checklist

- [ ] I can write LINQ queries using method and query syntax
- [ ] I know how to filter, project, and sort data with LINQ
- [ ] I explored the Microsoft Learn LINQ module
