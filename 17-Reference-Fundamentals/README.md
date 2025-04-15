# Module 17: Reference Fundamentals

In this module, you'll learn the difference between value types and reference types — a core concept in how C# handles memory and data.

---

## 💡 What You'll Learn
- What value and reference types are
- How data is stored and passed differently
- The difference in behavior when assigning or modifying variables
- What `ref`, `out`, and `in` mean

---

## ✍️ Code Examples

### Value vs Reference
```csharp
int a = 5;
int b = a;
b++;
Console.WriteLine(a);  // 5 (original unchanged)
Console.WriteLine(b);  // 6

int[] arr1 = { 1, 2, 3 };
int[] arr2 = arr1;
arr2[0] = 99;
Console.WriteLine(arr1[0]);  // 99 (shared reference)
```

### Using `ref` and `out`
```csharp
void Increment(ref int number)
{
    number++;
}

int value = 10;
Increment(ref value);
Console.WriteLine(value);  // 11
```

---

## 🧠 Key Concepts

- Value types (`int`, `double`, `bool`, `struct`) copy data
- Reference types (`class`, `array`, `string`) share references
- `ref` allows passing by reference (original is modified)
- `out` allows returning multiple values

---

## 🎓 Extra Learning (Microsoft C# Training)

🔗 [Use Value and Reference Types in C#](https://learn.microsoft.com/en-us/training/modules/csharp-value-reference-types/)

---

## ✅ Checklist

- [ ] I understand value vs reference type behavior
- [ ] I can use `ref` and `out` parameters
- [ ] I know which types are reference and which are value
- [ ] I explored the Microsoft Learn module
