# Module 9: Loops

In this module, you'll learn how to repeat actions using loops — one of the most powerful tools in programming.

---

## 💡 What You'll Learn
- How and when to use `for`, `while`, and `do-while` loops
- Loop control: `break`, `continue`
- Common loop patterns
- Looping through arrays or counters

---

## ✍️ Code Examples

### `for` loop
```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Number" + i);
}
```

### `while` loop
```csharp
int count = 0;
while (count < 3)
{
    Console.WriteLine("Hello");
    count++;
}
```

### `do-while` loop
```csharp
int number;
do
{
    Console.WriteLine("Enter a number:");
    number = int.Parse(Console.ReadLine());
}
while (number != 0);
```

---

## 🧠 Key Concepts

- `for`: when you know how many times to loop
- `while`: when the end is based on a condition
- `do-while`: when you want to run the code at least once
- Use `break` to exit early, `continue` to skip current iteration

---

## 🎓 Extra Learning (Microsoft C# Training)

🔗 [Branch the Flow of Code Using the for Statement, while, and do-while](https://learn.microsoft.com/en-us/training/modules/csharp-looping-constructs/)

This module covers:
- Repetition logic
- Pattern creation
- Controlling flow during loops

---

## ✅ Checklist

- [ ] I understand when to use each type of loop
- [ ] I can use `break` and `continue`
- [ ] I can loop through arrays or sets
- [ ] I explored the Microsoft Learn resources
