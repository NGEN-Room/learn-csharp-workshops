# Module 2: Hello, World!

Now that your environment is ready, it’s time to write your first C# program from scratch!

---

## 💡 What You'll Learn

- The structure of a basic C# console app
- How to print messages to the console using `Console.WriteLine()`
- How to edit and run a `.cs` file

---

## ✍️ Step-by-Step: Build Your First App

### 1. Create the Project
As a rule of thumb keep all moudleized project within the modules i.e.: 02-Hello-World/*Project name*. you are also more than welcome to build the project with in the projects folder, to do that change your directory to the folder you wish to save your projects
From the terminal:
```bash
dotnet new console -o HelloWorldApp
cd HelloWorldApp
```

### 2. Understand the Code

Open `Program.cs`. You’ll see:

```csharp
﻿Console.WriteLine("Hello, World!");
```

### 3. Modify the Message

Change it to:

```csharp
Console.WriteLine("Hello, my name is [YourName]!");
Console.WriteLine("I'm learning C#.");
```

Then run the program:
```bash
dotnet run
```

---

## ✅ Checklist

- [ ] Created a console app using `dotnet new console`
- [ ] Modified the `Console.WriteLine()` output
- [ ] Ran the app using `dotnet run`

---

## Project

- change your directory to the Projects folder
- follow the instructions on there to build your first project.
- use this file as a template