# 🟢 SOLID Principles Practice in C#

Welcome to my first C# practice project focused on the **SOLID principles** of object-oriented design.

This project is part of my hands-on learning journey after completing the W3Schools C# tutorial. Here, I have implemented simple examples for each of the five SOLID principles to understand their purpose, importance, and how they are applied in real-world scenarios.

---

## 📌 What are SOLID Principles?

**SOLID** is an acronym for five design principles intended to make software designs more understandable, flexible, and maintainable:

1. **S** - Single Responsibility Principle (SRP)
2. **O** - Open/Closed Principle (OCP)
3. **L** - Liskov Substitution Principle (LSP)
4. **I** - Interface Segregation Principle (ISP)
5. **D** - Dependency Inversion Principle (DIP)

---

## 🏗️ Project Structure

```
SolidPrinciples/
│
├── S/   --> Single Responsibility Principle Example
├── O/   --> Open/Closed Principle Example
├── L/   --> Liskov Substitution Principle Example
├── I/   --> Interface Segregation Principle Example
├── D/   --> Dependency Inversion Principle Example
├── Program.cs  --> Main console app to select and run each principle
└── README.md   --> This file
```

---

## 🚀 How to Run

Make sure you have the .NET SDK installed on your machine.

1. Clone the repository:

```bash
git clone https://github.com/yourusername/SOLID-Practice-CSharp.git
cd SOLID-Practice-CSharp
```

2. Build the project:

```bash
dotnet build
```

3. Run the program:

```bash
dotnet run
```

4. Follow the console instructions to select which principle example to run.

---

## 💡 Implemented Principles Explained

| Principle                 | Summary                                                                                        | Example Scenario                                                                |
| ------------------------- | ---------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| **Single Responsibility** | A class should only have one reason to change.                                                 | Separating report data from file-saving logic.                                  |
| **Open/Closed**           | Software should be open for extension, but closed for modification.                            | Adding new notification types (email, SMS) without changing existing code.      |
| **Liskov Substitution**   | Subtypes must be substitutable for their base types.                                           | Bird example: FlyingBird vs Penguin (non-flying bird).                          |
| **Interface Segregation** | Clients should not depend on interfaces they do not use.                                       | Separate interfaces for Work and Eat actions.                                   |
| **Dependency Inversion**  | High-level modules should not depend on low-level modules. Both should depend on abstractions. | Notification sender depends on `INotification` interface, not concrete classes. |

---

## 🧭 Why This Project?

✅ To practice writing clean, maintainable, and extendable code in C#  
✅ To understand the fundamental object-oriented design principles  
✅ To prepare myself for real-world software development scenarios
