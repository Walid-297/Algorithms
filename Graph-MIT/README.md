# 🌳 Prim's Minimum Spanning Tree (MST)

A clean and educational implementation of **Prim's Algorithm** using **Greedy Algorithms** in **C#** and **.NET 8**.

This project demonstrates how Prim's Algorithm constructs a **Minimum Spanning Tree (MST)** by repeatedly selecting the lowest-weight edge that connects a new vertex to the growing tree.

The implementation focuses on:

- Greedy Algorithms
- Graph theory
- Minimum Spanning Trees (MST)
- Weighted undirected graphs
- Adjacency Matrix representation

---

## 📖 Overview

A **Minimum Spanning Tree (MST)** is a subset of the edges in a connected, weighted, undirected graph that:

- Connects every vertex
- Contains no cycles
- Has the minimum possible total edge weight

Prim's Algorithm is a **Greedy Algorithm** that builds the MST one vertex at a time.

Starting from an arbitrary vertex, it repeatedly selects the cheapest edge that connects the current tree to an unvisited vertex until all vertices are included.

---

## ✨ Features

- Greedy Algorithm implementation
- Minimum Spanning Tree construction
- Adjacency Matrix graph representation
- Efficient minimum-edge selection
- Displays selected edges and total cost
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
PrimsMST/
├── PrimsSolver.cs           # Prim's Algorithm implementation
├── Program.cs               # Application entry point
├── PrimsMST.csproj
└── PrimsMST.sln
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
git clone https://github.com/YourUsername/PrimsMST.git
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
        2
    A ------- B
   / \        |
 6/   \3      |8
 /     \      |
C-------D-----E
    5      7
```

### Minimum Spanning Tree

```text
A — B (2)

A — D (3)

D — C (5)

D — E (7)
```

### Total Weight

```text
17
```

---

## 🧠 How the Algorithm Works

Prim's Algorithm grows the Minimum Spanning Tree by repeatedly selecting the smallest edge that connects a visited vertex to an unvisited one.

---

### Step 1 — Initialize

Create three arrays:

- **Key** → Stores the minimum edge weight needed to reach each vertex.
- **Parent** → Stores the parent of each vertex in the MST.
- **Visited** → Tracks whether a vertex has already been added to the MST.

Initialize:

- All keys = ∞
- Starting vertex = 0
- All vertices = unvisited

---

### Step 2 — Select the Minimum Key

Among all unvisited vertices, choose the one with the smallest key value.

This vertex becomes part of the MST.

---

### Step 3 — Update Neighboring Vertices

For every adjacent vertex:

- Ignore vertices already in the MST.
- If the current edge weight is smaller than the stored key:
  - Update the key.
  - Update the parent.

---

### Step 4 — Repeat

Continue selecting the smallest available edge until every vertex has been added to the Minimum Spanning Tree.

---

## 💡 Why Greedy Works

Prim's Algorithm always chooses the cheapest edge that expands the current tree.

Although it makes a **local optimal choice** at each step, this strategy is mathematically proven to produce the **global optimal Minimum Spanning Tree** for connected, weighted, undirected graphs.

---

## 📊 Complexity Analysis

| Implementation | Time Complexity |
|---------------|-----------------|
| Adjacency Matrix | O(V²) |
| Binary Heap + Adjacency List | O(E log V) |

Where:

- **V** = Number of vertices
- **E** = Number of edges

### Space Complexity

| Complexity Type | Value |
|-----------------|-------|
| Space Complexity | O(V²) *(Adjacency Matrix)* |

---

## ⚖️ Prim's vs Kruskal's Algorithm

| Feature | Prim's | Kruskal's |
|----------|---------|-----------|
| Strategy | Grow one tree | Select smallest edges globally |
| Data Structure | Priority Queue / Matrix | Disjoint Set (Union-Find) |
| Best For | Dense graphs | Sparse graphs |
| Greedy Choice | Minimum connecting edge | Minimum available edge |

---

## 🚀 Real-World Applications

Prim's Algorithm is commonly used in:

- Road network construction
- Electrical power distribution
- Water pipeline design
- Computer network topology
- Fiber optic cable routing
- Circuit design
- Image segmentation
- Cluster analysis

---

## 📚 Learning Outcomes

By building this project, you practice:

- Greedy Algorithms
- Graph theory
- Minimum Spanning Trees
- Adjacency Matrix representation
- Graph traversal concepts
- Complexity analysis
- Clean C# implementation

---

## 🔮 Future Improvements

Possible enhancements include:

- Adjacency List implementation
- Priority Queue optimization
- Binary Heap implementation
- Interactive graph input
- Graph visualization
- Compare with Kruskal's Algorithm
- Unit testing with xUnit

---

## 📄 License

This project is created for educational purposes.