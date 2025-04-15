# Module 8: Arrays

In this module, you'll learn how to store and work with collections of data using arrays in C#.

---

## 💡 What You'll Learn
- What arrays are and how they work
- How to declare, initialize, and access array elements
- Looping through arrays with `for` and `foreach`
- Performing basic operations on arrays

---

## ✍️ Code Examples

### Syntax
datatype[] arrayName = 


```csharp
// how to declare a interger array
int[] intergerArray = new int[5] // give me an array that can hold 5 intergers
int[] intergerArrayTwo = new int[] { 1, 2, 3 } // give me a prefilled array with intergers 1, 2, 3

// how to declare a string array
string[] stringArray = new string[5] // give me an array that can hold 5 strigns
string[] stringArrayTwo = new string {"harry", "Leonard", "Mary"} // give me a prefilled array of strings that holds "harry", "Leonard", "Mary"

```

### Declare and initialize an array
```csharp
int[] scores = new int[] { 90, 85, 72 };
Console.WriteLine(scores[0]);  // 90
```

### Modify array values
```csharp
scores[1] = 88;
```

### Loop through an array
```csharp
foreach (int score in scores)
{
    Console.WriteLine(score);
}
```

### Using `Length` property
```csharp
Console.WriteLine("Number of scores: " + scores.Length);
```

---

## 🧠 Key Concepts

- Arrays hold fixed-size groups of elements of the same type
- Use `[index]` to access elements (index starts at 0)
- `Length` tells you how many items are in the array
- Use `for` or `foreach` to loop through arrays

---

## 🎓 Extra Learning (Microsoft C# Training)

🔗 [Store and Iterate Through Sequences of Data Using Arrays and foreach](https://learn.microsoft.com/en-us/training/modules/csharp-store-sequence-data/)

This module covers:
- Creating arrays
- Looping through them
- Modifying their contents safely

---

## ✅ Checklist

- [ ] I can declare and access array values
- [ ] I know how to loop through arrays
- [ ] I understand how indexing works
- [ ] I explored the Microsoft Learn array module
