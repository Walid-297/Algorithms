# 🎒 Fractional Knapsack Problem (Greedy Algorithm)

A clean and educational implementation of the **Fractional Knapsack Problem** using a **Greedy Algorithm** in **C#** and **.NET 8**.

This project demonstrates how greedy strategies can solve optimization problems by selecting items based on their **value-to-weight ratio**, allowing fractions of items to maximize the total value within a limited capacity.

The implementation focuses on:

- Greedy algorithm design
- Resource optimization
- Value-to-weight ratio analysis
- Fractional item selection
- Object-oriented programming

---

## 📖 Overview

The Fractional Knapsack Problem is a classic optimization problem in which a knapsack has a limited weight capacity, and each available item has:

- A value
- A weight

Unlike the **0/1 Knapsack Problem**, items **can be divided into fractions**. If an item cannot completely fit into the remaining capacity, only the necessary fraction is taken.

The greedy strategy guarantees the optimal solution by always choosing the item with the highest value per unit of weight.

---

## ✨ Features

- Greedy optimization strategy
- Value-to-weight ratio calculation
- Fractional item selection
- Automatic item prioritization
- Object-oriented design
- Beginner-friendly implementation
- Clean and modular architecture

---

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET 8
- **IDE:** Visual Studio 2022

---

## 📂 Project Structure

```text
FractionalKnapsack/
├── Item.cs                     # Represents an item with value, weight, and ratio
├── Knapsack.cs                 # Manages capacity and selected items
├── Program.cs                  # Application entry point
├── FractionalKnapsack.csproj
└── FractionalKnapsack.sln
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
git clone https://github.com/YourUsername/FractionalKnapsack.git
```

---

### Run the Project

```bash
dotnet run
```

---

## 💻 Example Dataset

```text
Capacity = 50

Item A
Weight = 10
Value = 60

Item B
Weight = 20
Value = 100

Item C
Weight = 30
Value = 120
```

---

## 🧠 How the Algorithm Works

The algorithm follows four simple steps.

### Step 1 — Calculate Value Density

For every item, calculate its value per unit of weight.

```text
Value Density = Value / Weight
```

Example:

| Item | Value | Weight | Ratio |
|------|------:|-------:|------:|
| A | 60 | 10 | 6 |
| B | 100 | 20 | 5 |
| C | 120 | 30 | 4 |

---

### Step 2 — Sort Items

Sort all items in **descending order** based on their value density.

```text
A → B → C
```

The most valuable item per unit weight is selected first.

---

### Step 3 — Fill the Knapsack

Process each item in order.

- If the item fits completely, take it.
- Otherwise, take only the fraction that fits.

Example:

```text
Capacity = 50

Take A completely
Remaining Capacity = 40

Take B completely
Remaining Capacity = 20

Take 20/30 of C
```

---

### Step 4 — Stop

Once the knapsack reaches its maximum capacity, the algorithm terminates.

---

## 🎯 Greedy Choice Property

The Fractional Knapsack Problem satisfies the greedy-choice property.

By always selecting the item with the highest value-to-weight ratio first, the algorithm guarantees the maximum possible total value.

Unlike the **0/1 Knapsack Problem**, no dynamic programming is required because items are divisible.

---

## 📊 Complexity Analysis

| Complexity Type | Value |
|-----------------|-------|
| Density Calculation | O(n) |
| Sorting | O(n log n) |
| Selection | O(n) |
| Overall Time Complexity | O(n log n) |
| Space Complexity | O(1) *(excluding input storage)* |

---

## ⚖️ Fractional vs 0/1 Knapsack

| Feature | Fractional Knapsack | 0/1 Knapsack |
|---------|---------------------|--------------|
| Items Divisible | ✅ Yes | ❌ No |
| Greedy Solution | ✅ Optimal | ❌ Not Optimal |
| Dynamic Programming Needed | ❌ No | ✅ Yes |
| Time Complexity | O(n log n) | O(n × W) |

---

## 🚀 Real-World Applications

The Fractional Knapsack Problem appears in many real-world optimization scenarios, including:

- Cargo loading
- Supply chain optimization
- Investment portfolio allocation
- Resource distribution
- Cloud resource scheduling
- Budget planning
- Material cutting and blending

---

## 📚 Learning Outcomes

By building this project, you practice:

- Greedy Algorithms
- Optimization techniques
- Sorting based on custom criteria
- Object-oriented programming
- Algorithm complexity analysis
- Resource allocation strategies

---

## 🔮 Future Improvements

Possible enhancements include:

- Interactive user input
- Generic item support
- Visual simulation of the filling process
- Comparison with the 0/1 Knapsack algorithm
- Performance benchmarking
- Unit testing with xUnit

---

## 📄 License

This project is created for educational purposes.