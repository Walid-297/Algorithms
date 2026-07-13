# 🚏 Stagecoach Problem (Dynamic Programming)

A clean and educational implementation of the **Stagecoach Problem** using **Dynamic Programming** in **C#** and **.NET 8**.

This project demonstrates how Dynamic Programming can efficiently solve multi-stage optimization problems by breaking them into smaller subproblems and reusing previously computed solutions.

The implementation focuses on:

- Dynamic Programming
- Bellman's Principle of Optimality
- Multi-stage decision making
- Shortest path optimization
- Cost caching and path reconstruction

---

## 📖 Overview

The Stagecoach Problem is a classic Dynamic Programming problem used to introduce sequential optimization.

A traveler must move from a starting city to a destination through several intermediate stages. At every stage, multiple routes may exist with different travel costs.

The objective is to determine the **minimum total cost path** from the source to the destination.

Instead of evaluating every possible path, Dynamic Programming computes the optimal solution by solving smaller subproblems only once and storing their results.

---

## ✨ Features

- Dynamic Programming solution
- Multi-stage graph optimization
- Cost-to-go computation
- Optimal path reconstruction
- Efficient reuse of subproblem solutions
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
StagecoachProblem/
├── StageCoachSolver.cs          # Dynamic Programming implementation
├── Program.cs                   # Application entry point
├── StagecoachProblem.csproj
└── StagecoachProblem.sln
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
git clone https://github.com/YourUsername/StagecoachProblem.git
```

---

### Run the Project

```bash
dotnet run
```

---

## 🧠 Problem Statement

Given a network divided into stages, determine the least expensive path from the starting node to the destination.

Each edge has an associated travel cost.

The algorithm computes the minimum cumulative cost while remembering the optimal decision made at every stage.

---

## 🔄 How the Algorithm Works

The solution follows a Dynamic Programming approach.

### Step 1 — Divide the Network into Stages

The graph is organized into consecutive stages.

Example:

```text
Stage 1 → Stage 2 → Stage 3 → Destination
```

Each node only connects to nodes in the next stage.

---

### Step 2 — Start from the Destination

Assign the destination node a cost of:

```text
Cost(Destination) = 0
```

This serves as the base case.

---

### Step 3 — Compute Minimum Cost Backwards

For every node:

```
Minimum Cost =
Minimum(
    Edge Cost +
    Cost of Next Node
)
```

The algorithm evaluates every possible outgoing edge and stores the smallest total cost.

---

### Step 4 — Cache the Results

Each computed minimum cost is stored.

This avoids recalculating the same subproblem multiple times.

Example:

```text
City B → Minimum Cost = 18

City C → Minimum Cost = 11

City D → Minimum Cost = 7
```

---

### Step 5 — Reconstruct the Optimal Path

After computing the minimum cost for every node, follow the recorded decisions from the starting city until the destination is reached.

Example:

```text
A → C → F → J
```

---

## 💡 Bellman's Principle of Optimality

The Stagecoach Problem is based on **Bellman's Principle of Optimality**:

> An optimal solution is composed of optimal solutions to its subproblems.

In other words:

If the best route from **A** passes through **C**, then the route from **C** to the destination must also be optimal.

This property makes Dynamic Programming applicable.

---

## 📊 Complexity Analysis

| Complexity Type | Value |
|-----------------|-------|
| Time Complexity | O(E) |
| Space Complexity | O(V) |

Where:

- **V** = Number of vertices (cities)
- **E** = Number of edges (roads)

Because every edge is evaluated only once, the algorithm is significantly more efficient than exploring every possible path.

---

## 🚀 Real-World Applications

The Stagecoach Problem models many real-world optimization problems, including:

- Route planning
- GPS navigation systems
- Supply chain optimization
- Logistics and transportation
- Project scheduling
- Multi-stage investment planning
- Reinforcement Learning foundations

---

## 📚 Learning Outcomes

By building this project, you practice:

- Dynamic Programming
- Bellman's Principle of Optimality
- Multi-stage optimization
- Shortest path problems
- Memoization techniques
- Algorithm complexity analysis
- Clean C# implementation

---

## 🔮 Future Improvements

Possible enhancements include:

- Interactive graph input
- Graph visualization
- Comparison with Dijkstra's Algorithm
- Comparison with Bellman-Ford Algorithm
- Generic graph support
- Unit testing with xUnit

---

## 📄 License

This project is created for educational purposes.