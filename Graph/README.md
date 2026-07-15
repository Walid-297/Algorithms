# 📊 Graph Representation

A clean and educational implementation of **Graph Representation** techniques using **C#** and **.NET 8**.

This project demonstrates the two most common ways to represent graphs in memory:

- **Adjacency Matrix**
- **Adjacency List**

These representations form the foundation for many graph algorithms, including **Breadth-First Search (BFS)**, **Depth-First Search (DFS)**, **Dijkstra's Algorithm**, **Prim's Algorithm**, and **Kruskal's Algorithm**.

The implementation focuses on:

- Graph data structures
- Memory-efficient graph storage
- Network modeling
- Object-oriented design
- Preparing for graph algorithms

---

## 📖 Overview

A **graph** is a non-linear data structure consisting of:

- **Vertices (Nodes)** — Represent entities.
- **Edges** — Represent relationships between vertices.

Graphs are widely used to model real-world systems such as:

- Social networks
- Road maps
- Computer networks
- Flight routes
- Recommendation systems
- Dependency graphs

Before implementing graph algorithms, an efficient representation of the graph is required.

This project introduces the two standard graph representations used in computer science.

---

## ✨ Features

- Adjacency Matrix implementation
- Adjacency List implementation
- Object-oriented graph design
- Easy graph construction
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
GraphRepresentation/
├── GraphRepresentation.cs      # Graph representation implementation
├── Program.cs                  # Application entry point
├── GraphRepresentation.csproj
└── GraphRepresentation.sln
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
git clone https://github.com/YourUsername/GraphRepresentation.git
```

---

### Run the Project

```bash
dotnet run
```

---

## 🧠 Graph Basics

A graph consists of:

```text
Vertices (V)

A, B, C, D
```

connected by

```text
Edges (E)

A → B

A → C

C → D
```

Example:

```text
     A
    / \
   B   C
        \
         D
```

---

# 📌 Adjacency Matrix

The Adjacency Matrix stores graph connections inside a two-dimensional array.

Example:

```text
      A B C D

A     0 1 1 0

B     1 0 0 0

C     1 0 0 1

D     0 0 1 0
```

Each cell represents whether an edge exists between two vertices.

### Advantages

- Constant-time edge lookup **O(1)**
- Simple implementation
- Excellent for dense graphs

### Disadvantages

- Requires **O(V²)** memory
- Wastes space for sparse graphs

---

# 📌 Adjacency List

The Adjacency List stores only the neighbors of each vertex.

Example:

```text
A → B, C

B → A

C → A, D

D → C
```

Each vertex maintains a list of connected vertices.

### Advantages

- Requires only **O(V + E)** memory
- Excellent for sparse graphs
- Easy to traverse neighbors

### Disadvantages

- Edge lookup is slower than an adjacency matrix
- Requires searching a vertex's neighbor list

---

## ⚖️ Adjacency Matrix vs Adjacency List

| Feature | Adjacency Matrix | Adjacency List |
|----------|------------------|----------------|
| Space Complexity | O(V²) | O(V + E) |
| Edge Lookup | O(1) | O(degree) |
| Insert Edge | O(1) | O(1) |
| Remove Edge | O(1) | O(degree) |
| Best For | Dense Graphs | Sparse Graphs |

---

## 📊 Complexity Analysis

### Adjacency Matrix

| Operation | Complexity |
|-----------|------------|
| Add Edge | O(1) |
| Remove Edge | O(1) |
| Check Edge | O(1) |
| Traverse Graph | O(V²) |
| Space | O(V²) |

---

### Adjacency List

| Operation | Complexity |
|-----------|------------|
| Add Edge | O(1) |
| Remove Edge | O(degree) |
| Check Edge | O(degree) |
| Traverse Graph | O(V + E) |
| Space | O(V + E) |

Where:

- **V** = Number of vertices
- **E** = Number of edges

---

## 🚀 Real-World Applications

Graph representations are the foundation of many systems, including:

- GPS and navigation systems
- Social media networks
- Computer network routing
- Airline route planning
- Recommendation engines
- Dependency management
- Knowledge graphs

---

## 📚 Learning Outcomes

By building this project, you practice:

- Graph data structures
- Adjacency Matrix representation
- Adjacency List representation
- Graph complexity analysis
- Object-oriented programming
- Foundation for graph algorithms

---

## 🔮 Future Improvements

Possible enhancements include:

- Directed graphs
- Weighted graphs
- BFS (Breadth-First Search)
- DFS (Depth-First Search)
- Dijkstra's Algorithm
- Prim's Algorithm
- Kruskal's Algorithm
- Graph visualization

---

## 📄 License

This project is created for educational purposes.