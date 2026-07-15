# 🛣️ Dijkstra's Shortest Path Algorithm

A clean and educational implementation of **Dijkstra's Algorithm** using **Greedy Algorithms** in **C#** and **.NET 8**.

This project demonstrates how Dijkstra's Algorithm efficiently computes the **shortest paths from a single source vertex to all other vertices** in a weighted graph with **non-negative edge weights**.

The implementation focuses on:

- Greedy Algorithms
- Graph theory
- Shortest path computation
- Edge relaxation
- Weighted graphs

---

## 📖 Overview

**Dijkstra's Algorithm** is one of the most widely used shortest-path algorithms in computer science.

Given a weighted graph and a starting vertex, the algorithm determines the minimum distance from the source to every other reachable vertex.

By repeatedly selecting the unvisited vertex with the smallest known distance and relaxing its outgoing edges, Dijkstra's Algorithm guarantees the shortest paths for graphs with **non-negative edge weights**.

---

## ✨ Features

- Single-source shortest path computation
- Greedy optimization strategy
- Edge relaxation technique
- Weighted graph support
- Distance calculation for all reachable vertices
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
GraphDSP/
├── DijkstrasSolver.cs        # Dijkstra's Algorithm implementation
├── Program.cs                # Application entry point
├── GraphDSP.csproj
└── GraphDSP.sln
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
git clone https://github.com/YourUsername/GraphDSP.git
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
        4
    A ------- B
   /|         |\
 2/ |5      10| \3
 /  |         |  \
C---D---------E---F
 \6   \2     /4
  \    \    /
   \    \  /
     G
```

Starting Vertex:

```text
A
```

### Shortest Distances

```text
A → A = 0

A → B = 4

A → C = 2

A → D = 5

A → E = 9

A → F = 7

A → G = 7
```

---

## 🧠 How the Algorithm Works

Dijkstra's Algorithm repeatedly expands the closest unvisited vertex until the shortest distances to all reachable vertices are known.

---

### Step 1 — Initialize

Create two arrays:

- **Distance** → Stores the shortest known distance from the source.
- **Visited** → Tracks processed vertices.

Initialize:

- Source vertex = 0
- All other vertices = ∞
- All vertices = unvisited

---

### Step 2 — Select the Closest Vertex

Choose the unvisited vertex with the smallest tentative distance.

This vertex becomes the current vertex.

---

### Step 3 — Relax Adjacent Edges

For every neighboring vertex:

Calculate:

```text
New Distance =
Current Distance +
Edge Weight
```

If:

```text
New Distance < Stored Distance
```

Update the stored distance.

This process is called **Edge Relaxation**.

---

### Step 4 — Mark as Visited

Once all neighboring vertices have been processed, mark the current vertex as visited.

Its shortest distance is now finalized.

---

### Step 5 — Repeat

Continue until every reachable vertex has been processed.

---

## 💡 Why Greedy Works

At every step, Dijkstra's Algorithm selects the unvisited vertex with the smallest tentative distance.

Since all edge weights are **non-negative**, this choice is guaranteed to be optimal and never needs to be reconsidered.

---

## ⚠️ Limitation

Dijkstra's Algorithm **does not work correctly** if the graph contains **negative edge weights**.

For graphs with negative weights, use **Bellman-Ford Algorithm** instead.

---

## 📊 Complexity Analysis

### Adjacency Matrix Implementation

| Complexity Type | Value |
|-----------------|-------|
| Time Complexity | O(V²) |
| Space Complexity | O(V²) |

---

### Priority Queue Implementation

| Complexity Type | Value |
|-----------------|-------|
| Time Complexity | O((V + E) log V) |
| Space Complexity | O(V + E) |

Where:

- **V** = Number of vertices
- **E** = Number of edges

---

## ⚖️ Dijkstra vs BFS

| Feature | Dijkstra | BFS |
|----------|----------|-----|
| Graph Type | Weighted | Unweighted |
| Edge Weights | Non-negative | Equal weights |
| Strategy | Greedy | Level-order traversal |
| Data Structure | Priority Queue / Array | Queue |
| Finds Shortest Path | ✅ Yes | ✅ Yes (Unweighted Only) |

---

## 🚀 Real-World Applications

Dijkstra's Algorithm is widely used in:

- GPS navigation systems
- Google Maps and route planning
- Computer network routing (OSPF)
- Logistics and transportation optimization
- Robot navigation
- Video game pathfinding
- Airline route planning
- Communication networks

---

## 📚 Learning Outcomes

By building this project, you practice:

- Greedy Algorithms
- Graph theory
- Shortest path algorithms
- Edge relaxation
- Weighted graph traversal
- Complexity analysis
- Clean C# implementation

---

## 🔮 Future Improvements

Possible enhancements include:

- Priority Queue (Min-Heap) optimization
- Adjacency List implementation
- Path reconstruction
- Interactive graph input
- Graph visualization
- Compare with Bellman-Ford Algorithm
- Compare with Floyd-Warshall Algorithm
- Unit testing with xUnit

---

## 📄 License

This project is created for educational purposes.