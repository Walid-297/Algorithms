# 🎯 Activity Selection Problem (Greedy Algorithm)

A clean and educational implementation of the **Activity Selection Problem** using a **Greedy Algorithm** in **C#** and **.NET 8**.

This project demonstrates how greedy strategies can be used to solve optimization and scheduling problems by making the best local decision at each step.

The implementation focuses on:

- Greedy algorithm design
- Scheduling optimization
- Object-oriented programming
- Activity compatibility checking
- Algorithm efficiency and simplicity

---

## 📖 Overview

The Activity Selection Problem is a classic optimization problem in which a single resource (such as a person, processor, or meeting room) must perform the maximum possible number of non-overlapping activities.

Each activity has:

- A start time
- A finish time

The goal is to select the largest possible set of compatible activities.

The solution uses a greedy strategy by always choosing the activity that finishes earliest among the remaining available activities.

---

## ✨ Features

- Object-oriented activity representation
- Greedy selection strategy
- Activity compatibility checking
- Efficient scheduling solution
- Beginner-friendly implementation
- Clean and modular code structure

---

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET 8
- **IDE:** Visual Studio 2022

---

## 📂 Project Structure

```text
ActivitySelection/
├── Activity.cs             # Activity model
├── Program.cs              # Greedy algorithm implementation
├── ActivitySelection.csproj
└── ActivitySelection.sln
```

---

## ⚙️ Getting Started

### Prerequisites

Make sure you have installed:

- .NET 8 SDK
- Visual Studio 2022 or VS Code

---

### Clone the Repository

```bash
git clone https://github.com/YourUsername/ActivitySelection.git
```

---

### Run the Project

```bash
dotnet run
```

---

## 💻 Example Dataset

```csharp
var activities = new List<Activity>
{
    new Activity("A1", 1, 4),
    new Activity("A2", 3, 5),
    new Activity("A3", 0, 6),
    new Activity("A4", 5, 7),
    new Activity("A5", 8, 9),
    new Activity("A6", 5, 9)
};
```

---

## 🧠 How the Algorithm Works

The greedy solution follows three main steps:

### 1. Sort Activities

Sort all activities by their finish times in ascending order.

```text
A1(1,4)
A2(3,5)
A3(0,6)
A4(5,7)
A5(8,9)
A6(5,9)
```

---

### 2. Select the First Activity

Always choose the first activity because it finishes the earliest.

```text
Selected: A1
```

---

### 3. Select Compatible Activities

For each remaining activity:

- If Start ≥ Finish of the last selected activity → Select it.
- Otherwise → Skip it.

Example:

```text
A1 (1,4)  ✓
A4 (5,7)  ✓
A5 (8,9)  ✓
```

Selected activities:

```text
A1 → A4 → A5
```

---

## 🔄 Greedy Choice Property

The Activity Selection Problem can be solved optimally using a greedy approach because:

- Choosing the activity that finishes earliest leaves the maximum remaining time available.
- This creates the greatest opportunity to schedule future activities.
- The locally optimal choice leads to a globally optimal solution.

---

## 📊 Complexity Analysis

| Complexity Type | Value |
|-----------------|-------|
| Sorting | O(n log n) |
| Selection Scan | O(n) |
| Total Time Complexity | O(n log n) |
| Space Complexity | O(1) |

---

## 🚀 Real-World Applications

The Activity Selection Problem appears in many real-world scenarios:

- Meeting room scheduling
- CPU process scheduling
- Event planning
- Resource allocation systems
- Classroom scheduling
- Project task management

---

## 📚 Learning Outcomes

By building this project, you practice:

- Greedy algorithms
- Optimization techniques
- Scheduling problems
- Object-oriented programming
- Complexity analysis
- Designing efficient solutions

---

## 🔮 Future Improvements

Possible enhancements include:

- Interactive user input
- Activity visualization
- Weighted Activity Selection
- Unit testing with xUnit
- Performance benchmarking
- Generic scheduling framework

---

## 📄 License

This project is created for educational purposes.