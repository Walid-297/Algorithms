# 🗜️ Huffman Coding Algorithm

A clean and educational implementation of the **Huffman Coding** algorithm using **C#** and **.NET 8**.

This project demonstrates how **Greedy Algorithms** can be used to perform **lossless data compression** by generating optimal variable-length binary codes based on character frequencies.

The implementation focuses on:

- Greedy algorithm design
- Binary tree construction
- Prefix-free encoding
- Frequency analysis
- Efficient data compression

---

## 📖 Overview

Huffman Coding is one of the most widely used lossless compression algorithms in computer science.

Instead of assigning every character the same number of bits, Huffman Coding assigns:

- **Short binary codes** to frequently occurring characters.
- **Long binary codes** to less frequent characters.

This minimizes the total number of bits required to represent the original data while preserving all information.

---

## ✨ Features

- Greedy algorithm implementation
- Huffman Tree construction
- Prefix-free binary code generation
- Frequency analysis
- Object-oriented node representation
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
HuffmanCoding/
├── HeapNode.cs              # Represents a node in the Huffman Tree
├── Huffman.cs               # Core Huffman algorithm
├── Program.cs               # Application entry point
├── HuffmanCoding.csproj
└── HuffmanCoding.sln
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
git clone https://github.com/YourUsername/HuffmanCoding.git
```

---

### Run the Project

```bash
dotnet run
```

---

## 🧠 How Huffman Coding Works

The algorithm consists of five main stages.

### Step 1 — Count Character Frequencies

Analyze the input text and count the occurrence of every unique character.

Example:

```text
Input

BANANA
```

Frequency table:

```text
A → 3
N → 2
B → 1
```

---

### Step 2 — Create Leaf Nodes

Create one tree node for every unique character.

Each node stores:

- Character
- Frequency

Initially, every node is a leaf node.

---

### Step 3 — Build the Huffman Tree

Repeatedly:

1. Select the two nodes with the lowest frequencies.
2. Create a new parent node.
3. Assign the sum of both frequencies to the parent.
4. Insert the new node back into the collection.

Continue until only one node remains.

Example:

```text
    (6)
   /   \
 (3)   (3)
  A    / \
      B   N
```

---

### Step 4 — Generate Binary Codes

Traverse the tree.

- Left child → `0`
- Right child → `1`

Example:

```text
A → 0
B → 10
N → 11
```

These binary values become the Huffman codes.

---

### Step 5 — Encode the Message

Replace every character with its binary code.

Example:

```text
BANANA

↓

10 0 11 0 11 0
```

---

## 🔑 Prefix-Free Property

Huffman Coding generates **prefix-free codes**, meaning:

- No code is the prefix of another code.
- Every encoded message can be decoded uniquely.
- No separators are required between codes.

Example:

✅ Valid

```text
A → 0
B → 10
N → 11
```

❌ Invalid

```text
A → 0
B → 01
```

Because `0` is a prefix of `01`.

---

## 📊 Complexity Analysis

| Complexity Type | Value |
|-----------------|-------|
| Frequency Counting | O(n) |
| Tree Construction | O(k log k) |
| Code Generation | O(k) |
| Overall Time Complexity | O(n + k log k) |
| Space Complexity | O(k) |

> **n** = Total number of characters  
> **k** = Number of unique characters

---

## 🚀 Real-World Applications

Huffman Coding is widely used in:

- File compression
- ZIP archives
- GZIP compression
- JPEG image compression
- PNG image compression
- Data transmission
- Communication protocols

---

## 📚 Learning Outcomes

By building this project, you practice:

- Greedy Algorithms
- Binary Trees
- Tree Traversal
- Frequency Analysis
- Prefix Codes
- Data Compression
- Algorithm Complexity Analysis
- Object-Oriented Design in C#

---

## 🔮 Future Improvements

Possible enhancements include:

- Complete file compression and decompression
- Bit-level encoding instead of strings
- Priority Queue implementation using `PriorityQueue<TElement, TPriority>`
- Compression ratio calculation
- Huffman Tree visualization
- Unit testing with xUnit

---

## 📄 License

This project is created for educational purposes.