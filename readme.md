# Learn C# Workshops 🚀

Welcome to the **Learn C# Workshop Series** by NGEN Room — a hands-on journey into C# programming, designed for students and beginners.

This repo is structured for progressive learning through:
- 💡 Lessons  
- 📝 Quizzes  
- 💻 Projects  

---

## 🔧 How to Use

### 1. **Clone the Repository**
```bash
git clone https://github.com/NGEN-Room/learn-csharp-workshops.git
cd learn-csharp-workshops
```

---

### 2. **Create Your Own Branch**
As this repo is a work in progress, all students **must create their own branch** and work from that:

```bash
git checkout -b your-name
```

For example:
```bash
git checkout -b piha
```

- All your work will be saved under your branch.
- Every time you're ready to back up or submit your work, run:

```bash
git push -u origin your-name
```

> (Replace `your-name` with your actual branch name)

After that first push, you only need to run this after saving and committing your work:

```bash
git add .
git commit -m "your message here"
git push
```

---

### 3. **Pick a Workshop Folder**  
Each folder (e.g., `01-Environment`, `02-Hello-World`) contains:
- A `README.md` with your lesson
- A `quiz.md` with reflection questions
- A `/projects/` folder (if included) with coding challenges

---

### 4. **Run Your Code**
Make sure you have the .NET SDK installed:  
👉 https://dotnet.microsoft.com/en-us/download

Then run your app:
```bash
dotnet build
dotnet run
```

---

### 5. **Stay Up to Date**
New workshops are added regularly. To keep your branch up to date:

```bash
git checkout main
git pull origin main
git checkout your-name
git merge main
```

---

## ✅ Progress Tracker

You can tick off workshops as you go:

- [x] 01 - Environment Setup
- [ ] 02 - Hello World
- [ ] 03 - Data Types and Variables
- [ ] 04 - Numbers and Operators
- [ ] 05 - Strings
- [ ] 06 - Logic
- [ ] 07 - Conditionals
- [ ] 08 - Arrays
- [ ] 09 - Loops
- [ ] 10 - Lists
- [ ] 11 - Methods
- [ ] 12 - Intro to Classes
- [ ] 13 - Encapsulation
- [ ] 14 - Inheritance
- [ ] 15 - Polymorphism
- [ ] 16 - Interfaces
- [ ] 17 - Reference Fundamentals
- [ ] 18 - The Object Class
- [ ] 19 - String & Exceptions
- [ ] 20 - LINQ

---

## 🧑‍💻 For Contributors (Mentors/Facilitators)

Want to contribute to lessons or add projects?

1. Create a new branch:
```bash
git checkout -b feat/06-loops
```

2. Add content to the relevant workshop folder:
- `README.md` = lesson content  
- `quiz.md` = 3–5 review questions  
- `/projects/Project-1` = starter code + `README.md` instructions

3. Push and open a pull request to `main`.

---

## 💬 Questions?

If you're stuck or have questions:
- Raise an [issue](https://github.com/NGEN-Room/learn-csharp-workshops/issues)
- Talk to your mentor
- Or leave comments in your code!

---

Happy coding! ✨  
**— NGEN Room Tech Team**
