# Algorithms & Data Structures

A curated collection of classic **Algorithms** and **Data Structures** implemented in **C#** using **.NET 8**.

This repository was built as part of my journey to strengthen problem-solving skills and gain a deeper understanding of the fundamental algorithms commonly taught in Computer Science and expected in technical interviews.

Each project focuses on a single algorithm, providing a clean implementation, modular code structure, and detailed documentation explaining how the algorithm works and when it should be used.

---

# Repository Structure

```text
Algorithms/
│
├── Sorting Algorithms/
│   ├── Insertion Sort
│   └── Merge Sort
│
├── Searching Algorithms/
│   └── Binary Search
│
├── Greedy Algorithms/
│   ├── Activity Selection
│   ├── Fractional Knapsack
│   ├── Huffman Coding
│   └── Prim's Minimum Spanning Tree
│
├── Dynamic Programming/
│   ├── Stagecoach Problem
│   ├── Longest Common Subsequence (LCS)
│   └── 0-1 Knapsack
│
├── Graph Algorithms/
│   ├── Graph Representation
│   ├── Breadth-First Search (BFS)
│   ├── Depth-First Search (DFS)
│   └── Dijkstra's Shortest Path
│
└── String Algorithms/
    ├── Character Frequencies I
    └── Character Frequencies II
```

---

# Implemented Algorithms

## Sorting Algorithms

| Algorithm | Technique | Time Complexity |
|-----------|-----------|-----------------|
| Insertion Sort | Incremental Sorting | O(n²) |
| Merge Sort | Divide & Conquer | O(n log n) |

---

## Searching Algorithms

| Algorithm | Technique | Time Complexity |
|-----------|-----------|-----------------|
| Binary Search | Divide & Conquer | O(log n) |

---

## Greedy Algorithms

| Algorithm | Problem Solved | Time Complexity |
|-----------|----------------|-----------------|
| Activity Selection | Maximum compatible activities | O(n log n) |
| Fractional Knapsack | Maximum value under weight constraint | O(n log n) |
| Huffman Coding | Lossless data compression | O(n log n) |
| Prim's Minimum Spanning Tree | Minimum Spanning Tree | O(V²)* |

> *This implementation uses an adjacency matrix. Using a priority queue would improve the complexity to **O((V + E) log V)**.

---

## Dynamic Programming

| Algorithm | Problem Solved | Time Complexity |
|-----------|----------------|-----------------|
| Stagecoach Problem | Multi-stage shortest path | O(n²) |
| Longest Common Subsequence (LCS) | Sequence similarity | O(m × n) |
| 0-1 Knapsack | Optimal resource allocation | O(n × W) |

> **W** represents the maximum knapsack capacity.

---

## Graph Algorithms

| Algorithm | Purpose | Time Complexity |
|-----------|----------|-----------------|
| Graph Representation | Adjacency Matrix & Adjacency List | O(1)* |
| Breadth-First Search (BFS) | Graph traversal & shortest path in unweighted graphs | O(V + E) |
| Depth-First Search (DFS) | Graph traversal & connectivity | O(V + E) |
| Dijkstra's Shortest Path | Single-source shortest path | O(V²)* |

> *The current implementations use an adjacency matrix. A priority queue implementation of Dijkstra's algorithm runs in **O((V + E) log V)**.

---

## String Algorithms

| Algorithm | Purpose | Time Complexity |
|-----------|----------|-----------------|
| Character Frequencies I | ASCII frequency counting | O(n) |
| Character Frequencies II | Hash-based frequency counting with Merge Sort | O(n log n) |

# Technologies

- **Language:** C#
- **Framework:** .NET 8
- **IDE:** Visual Studio 2022
- **Paradigms:** Object-Oriented Programming (OOP)

---

# Learning Objectives

This repository demonstrates practical implementations of:

- Sorting Algorithms
- Searching Algorithms
- Greedy Algorithms
- Dynamic Programming
- Graph Algorithms
- String Processing Algorithms
- Divide & Conquer
- Recursion
- Optimization Techniques
- Time & Space Complexity Analysis

---

# Getting Started

## Prerequisites

- .NET 8 SDK
- Visual Studio 2022 (or any compatible IDE)

## Clone the Repository

```bash
git clone https://github.com/your-username/Algorithms.git
```

## Run a Project

Navigate to any project folder and execute:

```bash
dotnet run
```

---

# Repository Highlights

- Modular project organization
- Beginner-friendly implementations
- Professional README for every algorithm
- Clean and readable C# code
- Well-commented logic
- Suitable for interview preparation
- Easy to extend with additional algorithms

---

# Purpose

The goal of this repository is to build a comprehensive reference of classical algorithms while improving implementation skills, algorithmic thinking, and software engineering practices using C#.

Each project is intentionally separated into its own directory with independent source code and documentation to make studying, reviewing, and extending the implementations straightforward.

---

# License

This repository is intended for educational purposes.