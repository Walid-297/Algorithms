# 🌐 Breadth-First Search (BFS)

A clean and educational implementation of the **Breadth-First Search (BFS)** algorithm using **C#** and **.NET 8**.

This project demonstrates how BFS traverses a graph **level by level**, visiting all neighboring vertices before moving to the next level. The implementation uses a **queue** to ensure vertices are explored in the correct order.

The implementation focuses on:

- Graph traversal
- Queue data structure
- Level-order exploration
- Shortest paths in unweighted graphs
- Graph algorithms

---

## 📖 Overview

**Breadth-First Search (BFS)** is one of the fundamental graph traversal algorithms.

Starting from a source vertex, BFS explores every neighboring vertex before continuing to vertices at greater distances.

Unlike **Depth-First Search (DFS)**, which explores one path as deeply as possible, BFS visits vertices **level by level**, making it the ideal algorithm for finding the shortest path in **unweighted graphs**.

---

## ✨ Features

- Queue-based graph traversal
- Level-by-level exploration
- Visited node tracking
- Prevents infinite loops in cyclic graphs
- Finds shortest paths in unweighted graphs
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
GraphBFS/
├── BreadthFirstSearch.cs     # BFS implementation
├── Program.cs                # Application entry point
├── GraphBFS.csproj
└── GraphBFS.sln
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
git clone https://github.com/YourUsername/GraphBFS.git
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

### BFS Traversal

```text
A → B → C → D → E → F
```

---

## 🧠 How the Algorithm Works

Breadth-First Search explores the graph one level at a time using a **First-In, First-Out (FIFO)** queue.

---

### Step 1 — Initialize

Create:

- A queue to store vertices waiting to be explored.
- A visited array (or HashSet) to avoid visiting the same vertex multiple times.

---

### Step 2 — Visit the Starting Vertex

- Mark the starting vertex as visited.
- Enqueue it into the queue.

---

### Step 3 — Process the Queue

While the queue is not empty:

1. Remove the front vertex.
2. Process it (print, search, etc.).
3. Visit all unvisited neighboring vertices.
4. Mark each neighbor as visited.
5. Add each neighbor to the queue.

---

### Step 4 — Repeat

Continue until the queue becomes empty.

At this point, every reachable vertex has been visited.

---

## 💡 Why Use a Queue?

A queue follows the **First-In, First-Out (FIFO)** principle.

This guarantees that vertices are explored in increasing order of their distance from the starting vertex, allowing BFS to naturally perform a **level-order traversal**.

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

## ⚖️ BFS vs DFS

| Feature | BFS | DFS |
|----------|-----|-----|
| Data Structure | Queue | Stack / Recursion |
| Traversal Style | Level by level | Depth first |
| Shortest Path (Unweighted) | ✅ Yes | ❌ No |
| Memory Usage | Higher | Lower |
| Best For | Shortest paths | Backtracking & recursion |

---

## 🚀 Real-World Applications

Breadth-First Search is widely used in:

- Shortest path discovery in unweighted graphs
- Social network analysis
- Web crawling
- Network broadcasting
- GPS navigation (unweighted maps)
- Peer-to-peer networks
- Recommendation systems
- Puzzle and maze solving

---

## 📚 Learning Outcomes

By building this project, you practice:

- Graph traversal algorithms
- Queue data structures
- Graph representations
- Level-order exploration
- Shortest path concepts
- Complexity analysis
- Clean C# implementation

---

## 🔮 Future Improvements

Possible enhancements include:

- Path reconstruction between two vertices
- Adjacency List implementation
- Adjacency Matrix implementation
- Interactive graph input
- Graph visualization
- Compare BFS with DFS
- Unit testing with xUnit

---

## 📄 License

This project is created for educational purposes.