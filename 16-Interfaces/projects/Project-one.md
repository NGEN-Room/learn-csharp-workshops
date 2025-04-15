# Project – Payment Processor

## 🧠 Goal:
Use interfaces to process different payment methods.

## 🔧 Instructions:
1. Define an interface `IPaymentMethod` with a method `ProcessPayment()`
2. Create classes:
   - `CreditCardPayment` that prints "Processing credit card"
   - `PaypalPayment` that prints "Processing PayPal"
3. Create a list of `IPaymentMethod` and call `ProcessPayment()` for each

## ✅ Bonus Challenge:
- Add an `Amount` property to each class
- Display how much is being processed

---

## 🛠️ How To Start

Create a new console app:
```bash
dotnet new console -o PaymentApp
cd PaymentApp
```

Write your code in `Program.cs` and run:
```bash
dotnet run
```
