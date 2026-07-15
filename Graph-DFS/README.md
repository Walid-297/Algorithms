# 🌲 Depth-First Search (DFS)

A clean and educational implementation of the **Depth-First Search (DFS)** algorithm using **C#** and **.NET 8**.

This project demonstrates how DFS traverses a graph by exploring **as deeply as possible** along each branch before backtracking. The implementation uses a **stack (explicitly or through recursion)** to efficiently navigate graph structures.

The implementation focuses on:

- Graph traversal
- Stack data structure
- Recursive algorithms
- Backtracking
- Graph search techniques

---

## 📖 Overview

**Depth-First Search (DFS)** is one of the fundamental graph traversal algorithms.

Starting from a source vertex, DFS explores one path completely before returning to explore alternative paths.

Unlike **Breadth-First Search (BFS)**, which visits vertices level by level, DFS dives deep into the graph, making it especially useful for problems involving recursion, backtracking, and graph analysis.

---

## ✨ Features

- Stack-based graph traversal
- Recursive implementation
- Backtracking mechanism
- Visited node tracking
- Prevents infinite loops in cyclic graphs
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
DepthFirstSearch/
├── DepthFirstSearch.cs       # DFS implementation
├── Program.cs                # Application entry point
├── DepthFirstSearch.csproj
└── DepthFirstSearch.sln
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
git clone https://github.com/YourUsername/DepthFirstSearch.git
```

---

### Run the Project

```bash
dotnet run
```

---

## 💻 Example

### Input Graph

```text
        A
      /   \
     B     C
    / \     \
   D   E     F
```

### DFS Traversal

```text
A → B → D → E → C → F
```

> The exact traversal order may vary depending on the order in which neighbors are visited.

---

## 🧠 How the Algorithm Works

Depth-First Search explores one branch completely before moving to another.

It uses a **Last-In, First-Out (LIFO)** strategy, which can be implemented using either:

- An explicit **Stack**
- Recursive function calls (the call stack)

---

### Step 1 — Initialize

Create:

- A stack (or use recursion)
- A visited array (or HashSet) to track visited vertices

---

### Step 2 — Visit the Starting Vertex

- Mark the starting vertex as visited.
- Push it onto the stack (or call the recursive function).

---

### Step 3 — Explore Neighbors

For the current vertex:

- Visit each unvisited neighboring vertex.
- Mark it as visited.
- Continue exploring recursively (or push it onto the stack).

---

### Step 4 — Backtrack

When a vertex has no unvisited neighbors:

- Return to the previous vertex.
- Continue exploring remaining branches.

Repeat until every reachable vertex has been visited.

---

## 💡 Why Use a Stack?

A stack follows the **Last-In, First-Out (LIFO)** principle.

This allows DFS to always continue exploring the most recently discovered vertex before returning to previous vertices, naturally supporting deep exploration and backtracking.

---

## 📊 Complexity Analysis

| Complexity Type | Value |
|-----------------|-------|
| Time Complexity | O(V + E) |
| Space Complexity | O(V) |

Where:

- **V** = Number of vertices
- **E** = Number of edges

---

## ⚖️ DFS vs BFS

| Feature | DFS | BFS |
|----------|-----|-----|
| Data Structure | Stack / Recursion | Queue |
| Traversal Style | Depth first | Level by level |
| Shortest Path (Unweighted) | ❌ No | ✅ Yes |
| Memory Usage | Lower | Higher |
| Best For | Backtracking & recursion | Shortest paths |

---

## 🚀 Real-World Applications

Depth-First Search is widely used in:

- Maze and puzzle solving
- Cycle detection
- Topological sorting
- Connected components
- Dependency resolution
- Backtracking algorithms
- Path existence checking
- Artificial Intelligence search

---

## 📚 Learning Outcomes

By building this project, you practice:

- Graph traversal algorithms
- Stack data structures
- Recursive programming
- Backtracking techniques
- Graph representations
- Complexity analysis
- Clean C# implementation

---

## 🔮 Future Improvements

Possible enhancements include:

- Iterative DFS using an explicit stack
- Path reconstruction
- Interactive graph input
- Graph visualization
- Connected components detection
- Cycle detection
- Topological sorting
- Compare DFS with BFS
- Unit testing with xUnit

---

## 📄 License

This project is created for educational purposes.