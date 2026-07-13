# 🎒 0/1 Knapsack Problem (Dynamic Programming)

A clean and educational implementation of the **0/1 Knapsack Problem** using **Dynamic Programming** in **C#** and **.NET 8**.

This project demonstrates how Dynamic Programming efficiently solves optimization problems where each item must be **either completely selected or completely discarded**.

The implementation focuses on:

- Dynamic Programming
- Optimization techniques
- Matrix tabulation
- Resource allocation
- Binary decision making

---

## 📖 Overview

The **0/1 Knapsack Problem** is one of the most well-known optimization problems in computer science.

Given a collection of items, each with:

- A weight
- A value

and a knapsack with a limited capacity, the objective is to maximize the total value without exceeding the weight limit.

Unlike the **Fractional Knapsack Problem**, items **cannot be divided**. Each item has only two possible choices:

- **Take it (1)**
- **Leave it (0)**

This binary constraint makes a greedy solution insufficient, so Dynamic Programming is used to guarantee the optimal result.

---

## ✨ Features

- Dynamic Programming solution
- Bottom-up tabulation approach
- Binary item selection (0 or 1)
- Optimal value calculation
- Clean and modular architecture
- Beginner-friendly implementation

---

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET 8
- **IDE:** Visual Studio 2022

---

## 📂 Project Structure

```text
Knapsack01/
├── Knapsack01Solver.cs        # Dynamic Programming implementation
├── Program.cs                 # Application entry point
├── Knapsack01.csproj
└── Knapsack01.sln
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
git clone https://github.com/YourUsername/Knapsack01.git
```

---

### Run the Project

```bash
dotnet run
```

---

## 💻 Example

### Items

| Item | Weight | Value |
|------|-------:|------:|
| A | 2 | 12 |
| B | 1 | 10 |
| C | 3 | 20 |
| D | 2 | 15 |

Knapsack Capacity:

```text
5
```

Maximum Value:

```text
37
```

---

## 🧠 How the Algorithm Works

The algorithm builds a Dynamic Programming table.

Rows represent the available items.

Columns represent every possible knapsack capacity from `0` to the maximum capacity.

Each cell stores the maximum value obtainable using the first **i** items and a capacity of **w**.

---

### Step 1 — Create the DP Table

Allocate a matrix with dimensions:

```text
(Number of Items + 1) × (Maximum Capacity + 1)
```

The first row and first column are initialized to zero.

---

### Step 2 — Process Each Item

For every item, compare its weight with the current capacity.

---

### Case 1 — Item Doesn't Fit

If the item's weight exceeds the current capacity:

```text
dp[i][w] = dp[i-1][w]
```

The item cannot be selected.

---

### Case 2 — Item Fits

If the item fits, evaluate two possibilities.

#### Exclude the Item

```text
dp[i-1][w]
```

#### Include the Item

```text
Item Value + dp[i-1][w-Item Weight]
```

Choose the larger value.

```text
dp[i][w] =
max(
    Exclude,
    Include
)
```

---

### Step 3 — Fill the Table

The table is completed row by row until every item and every capacity have been evaluated.

---

### Step 4 — Retrieve the Result

The maximum obtainable value is stored in the bottom-right corner of the table.

```text
Maximum Value = dp[n][Capacity]
```

---

## 💡 Why Dynamic Programming?

A greedy strategy does **not** always produce the optimal solution for the 0/1 Knapsack Problem.

Dynamic Programming works because the problem has:

### Optimal Substructure

The optimal solution is built from optimal solutions to smaller subproblems.

### Overlapping Subproblems

Many combinations are evaluated repeatedly.

Dynamic Programming stores previously computed results, avoiding redundant calculations.

---

## ⚖️ 0/1 vs Fractional Knapsack

| Feature | 0/1 Knapsack | Fractional Knapsack |
|---------|--------------|---------------------|
| Item Division | ❌ No | ✅ Yes |
| Greedy Solution | ❌ Not Optimal | ✅ Optimal |
| Dynamic Programming | ✅ Required | ❌ Not Required |
| Time Complexity | O(n × W) | O(n log n) |

Where:

- **n** = Number of items
- **W** = Knapsack capacity

---

## 📊 Complexity Analysis

| Complexity Type | Value |
|-----------------|-------|
| Time Complexity | O(n × W) |
| Space Complexity | O(n × W) |

Where:

- **n** = Number of items
- **W** = Maximum knapsack capacity

---

## 🚀 Real-World Applications

The 0/1 Knapsack Problem appears in many optimization scenarios, including:

- Cargo loading
- Budget allocation
- Investment selection
- Resource management
- Cloud computing resource allocation
- Project portfolio optimization
- Manufacturing and logistics

---

## 📚 Learning Outcomes

By building this project, you practice:

- Dynamic Programming
- Matrix tabulation
- Optimization techniques
- Binary decision making
- Complexity analysis
- Resource allocation problems
- Clean C# implementation

---

## 🔮 Future Improvements

Possible enhancements include:

- Reconstruct the selected items
- Space-optimized Dynamic Programming
- Recursive memoization solution
- Interactive console input
- Performance comparison with Greedy algorithms
- Unit testing with xUnit

---

## 📄 License

This project is created for educational purposes.