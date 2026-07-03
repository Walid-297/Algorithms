# 🔤 Sorted Characters Frequencies II

A clean and educational implementation of two different approaches for calculating character frequencies using **C#** and **.NET 8**.

This project compares the performance and design of:

- **Direct Addressing (ASCII Frequency Table)**
- **Hash Table + Merge Sort**

The goal is to demonstrate how different data structures and algorithms can solve the same problem while offering different advantages and trade-offs.

---

## 📖 Overview

The application analyzes a text string and counts how many times each character appears.

Two independent implementations are provided:

1. **ASCII Direct Addressing**
   - Uses a fixed-size integer array indexed by ASCII values.
   - Extremely fast for standard ASCII characters.

2. **Hash Table + Merge Sort**
   - Uses a hash table to support any character.
   - Sorts characters according to their frequencies using a custom Merge Sort implementation.

This project serves as a comparison between fixed-memory indexing and dynamic data structures.

---

## ✨ Features

- Two independent character counting implementations
- ASCII frequency table using Direct Addressing
- Dynamic Hash Table implementation
- Custom Merge Sort implementation
- Frequency-based sorting
- Educational comparison between algorithmic approaches
- Clean and modular code

---

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET 8
- **IDE:** Visual Studio 2022

---

## 📂 Project Structure

```text
SortedCharactersFrequenciesII/
├── CharFreq.cs                     # Frequency counting implementations
├── Program.cs                      # Application entry point
├── SortedCharactersFrequenciesII.csproj
└── SortedCharactersFrequenciesII.sln
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
git clone https://github.com/YourUsername/SortedCharactersFrequenciesII.git
```

---

### Run the Project

```bash
dotnet run
```

---

## 💻 Example Input

```text
Hello World
```

---

## 🖥️ Example Output

### ASCII Direct Addressing

```text
' ' : 1
'H' : 1
'W' : 1
'd' : 1
'e' : 1
'l' : 3
'o' : 2
'r' : 1
```

### Hash Table + Merge Sort

```text
'l' : 3
'o' : 2
'H' : 1
'e' : 1
'W' : 1
'r' : 1
'd' : 1
' ' : 1
```

The second implementation sorts the output according to character frequency.

---

## 🧠 Algorithm 1 — ASCII Direct Addressing

This approach uses a fixed-size integer array.

### Steps

1. Create an integer array of size **127**.
2. Convert every character into its ASCII value.
3. Use the ASCII value directly as the array index.
4. Increment the corresponding frequency.
5. Scan the array sequentially to display results.

### Advantages

- Extremely fast
- Constant memory usage
- No hashing required
- Automatically ordered by ASCII value

### Limitation

Supports only standard ASCII characters.

---

## 🧠 Algorithm 2 — Hash Table + Merge Sort

This implementation supports any character.

### Step 1 — Frequency Collection

Characters are stored inside a Hash Table where:

- Key → Character
- Value → Frequency

---

### Step 2 — Matrix Conversion

The hash table entries are copied into a two-dimensional integer array.

Each row stores:

```text
Character Code | Frequency
```

---

### Step 3 — Merge Sort

The matrix is sorted using a custom Merge Sort implementation based on frequency values.

This allows the output to be displayed from the least frequent to the most frequent (or vice versa depending on implementation).

---

## ⚖️ Comparison

| Feature | ASCII Table | Hash Table + Merge Sort |
|----------|-------------|-------------------------|
| Character Support | ASCII Only | Any Character |
| Memory Usage | Constant | Dynamic |
| Counting Speed | Very Fast | Fast |
| Output Order | ASCII Order | Frequency Order |
| Sorting Required | No | Yes |

---

## 📊 Complexity Analysis

### ASCII Direct Addressing

| Complexity Type | Value |
|-----------------|-------|
| Counting | O(n) |
| Printing | O(127) ≈ O(1) |
| Overall | O(n) |
| Space | O(1) |

---

### Hash Table + Merge Sort

| Complexity Type | Value |
|-----------------|-------|
| Counting | O(n) |
| Merge Sort | O(k log k) |
| Overall | O(n + k log k) |
| Space | O(k) |

> **n** = Number of characters in the input  
> **k** = Number of unique characters

---

## 🚀 Why This Project Matters

This project demonstrates several important computer science concepts:

- Direct Addressing
- Hash Tables
- Merge Sort
- Frequency Analysis
- Complexity Analysis
- Algorithm Comparison
- Data Structure Trade-offs

It also highlights how different solutions can solve the same problem while balancing speed, flexibility, and memory usage.

---

## 📚 Learning Outcomes

By building this project, you practice:

- Direct Addressing
- Hash Tables
- Merge Sort
- Frequency Analysis
- Two-dimensional arrays
- Algorithm comparison
- Time and space complexity analysis
- Clean C# implementation

---

## 🔮 Future Improvements

Possible enhancements include:

- Full Unicode support
- Generic Merge Sort implementation
- Performance benchmarking between both approaches
- Graphical histogram visualization
- Export results to CSV
- Unit testing with xUnit

---

## 📄 License

This project is created for educational purposes.