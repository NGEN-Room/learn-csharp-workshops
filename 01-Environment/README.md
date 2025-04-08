# Module 1: Setting Up Your Environment

Welcome to your first C# workshop! In this module, you'll set up your environment and get ready to build C# console apps.

---

## 🧰 What You'll Learn
- What C# and .NET are
- How to install the .NET SDK
- How to install and configure Visual Studio Code
- How to run your first C# program from the terminal

---

## 🚀 Step-by-Step Setup

### 1. Install the .NET SDK
Go to: https://dotnet.microsoft.com/en-us/download

- Download and install the **latest .NET SDK**
- Confirm installation in your terminal:
```bash
dotnet --version
```

### 2. Install Visual Studio Code
Download here: https://code.visualstudio.com/

- Install the **C# Extension** by Microsoft (Omnisharp)
- Recommended Extensions:
  - C#
  - Code Runner
  - GitLens

### 3. Create Your First Project
Make sure your terminal points to /01-Enviroment for this next session. Open your terminal and run:

```bash
dotnet new console -o MyFirstApp
cd MyFirstApp
dotnet run
```

You should see:
```
Hello, World!
```

🎉 You're ready to start coding in C#!

---

## ✅ Checklist

- [ ] .NET SDK is installed
- [ ] VS Code is installed with C# extension
- [ ] First C# project runs successfully


---

## 💻 Platform Notes

This course is compatible with both **Windows** and **Mac**.

### 🪟 For Windows users:
- Open the **Command Prompt**, **PowerShell**, or **Git Bash**
- Use `cd` to navigate between folders
- File paths will look like: `C:\Users\YourName\MyFirstApp`

### 🍎 For Mac users:
- Use the **Terminal**
- File paths look like: `/Users/yourname/MyFirstApp`

✅ The `dotnet` CLI commands like `dotnet new`, `dotnet build`, and `dotnet run` work exactly the same on both platforms.
