# Project – Notification System

## 🧠 Goal:
Use polymorphism to send different types of notifications.

## 🔧 Instructions:
1. Create a base class `Notification` with a method `Send()`
2. Create two subclasses:
   - `EmailNotification` that overrides `Send()` to print “Sending Email...”
   - `SMSNotification` that overrides `Send()` to print “Sending SMS...”
3. In `Main`, store both in a `List<Notification>` and loop through to call `Send()`

## ✅ Bonus Challenge:
- Add a `Message` property to all notifications
- Show the message as part of the output

---

## 🛠️ How To Start

Create a new console app:
```bash
dotnet new console -o NotificationApp
cd NotificationApp
```

Write your code in `Program.cs` and run:
```bash
dotnet run
```
