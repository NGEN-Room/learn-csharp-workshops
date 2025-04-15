# Module 13: Encapsulation

In this module, you'll learn how to protect and control access to class data using encapsulation.

---

## 💡 What You'll Learn
- What encapsulation means and why it's important
- How to use `private`, `public`, and `protected` access modifiers
- How to use properties (`get`/`set`) to control access
- How encapsulation helps keep data safe and structured

---

## ✍️ Code Examples

### Private fields and public properties
```csharp
public class BankAccount
{
    private double balance;

    public double Balance
    {
        get { return balance; }
        set 
        {
            if (value >= 0)
                balance = value;
        }
    }
}
```

### Using the encapsulated class
```csharp
BankAccount account = new BankAccount();
account.Balance = 1000;  // uses the setter
Console.WriteLine(account.Balance);  // uses the getter
```

---

## 🧠 Key Concepts

- **Encapsulation** = hiding data and controlling access
- `private` keeps data internal to the class
- Use `public` methods or properties to safely interact with data
- Properties are preferred over public fields in most cases

---

## 🎓 Extra Learning (Microsoft C# Training)

🔗 [Encapsulate Data and Define Access Levels in C#](https://learn.microsoft.com/en-us/training/modules/csharp-encapsulation/)

This module covers:
- Access modifiers
- Property syntax
- Validation and protection of internal data

---

## ✅ Checklist

- [ ] I understand access modifiers (`private`, `public`)
- [ ] I can use properties to control data access
- [ ] I know why encapsulation is useful
- [ ] I explored the Microsoft Learn module
