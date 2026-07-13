# 🧩 Longest Common Subsequence (Dynamic Programming)

A clean and educational implementation of the **Longest Common Subsequence (LCS)** algorithm using **Dynamic Programming** in **C#** and **.NET 8**.

This project demonstrates how Dynamic Programming efficiently finds the longest subsequence shared between two strings by storing solutions to smaller subproblems in a two-dimensional table.

The implementation focuses on:

- Dynamic Programming
- Matrix tabulation
- String comparison
- Optimal substructure
- Sequence analysis

---

## 📖 Overview

The **Longest Common Subsequence (LCS)** problem is one of the most fundamental Dynamic Programming problems.

Given two strings, the objective is to determine the **longest sequence of characters that appears in both strings while preserving their relative order**.

Unlike a **substring**, the characters do **not** need to be consecutive.

Example:

```text
String 1 : ABCBDAB
String 2 : BDCABA

Longest Common Subsequence:

BCBA
```

---

## ✨ Features

- Bottom-up Dynamic Programming solution
- Matrix tabulation approach
- Efficient string comparison
- Optimal substructure utilization
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
LongestCommonSubsequence/
├── LCSSolver.cs               # Dynamic Programming implementation
├── Program.cs                 # Application entry point
├── LongestCommonSubsequence.csproj
└── LongestCommonSubsequence.sln
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
git clone https://github.com/YourUsername/LongestCommonSubsequence.git
```

---

### Run the Project

```bash
dotnet run
```

---

## 💻 Example

```text
String 1 = AGGTAB

String 2 = GXTXAYB
```

Output:

```text
Longest Common Subsequence = GTAB

Length = 4
```

---

## 🧠 How the Algorithm Works

The algorithm builds a Dynamic Programming table where:

- Rows represent characters of the first string.
- Columns represent characters of the second string.

Each cell stores the length of the LCS for the corresponding prefixes of both strings.

---

### Step 1 — Create the DP Table

Allocate a matrix with dimensions:

```text
(M + 1) × (N + 1)
```

where:

- **M** = Length of the first string
- **N** = Length of the second string

The extra row and column simplify the base cases.

---

### Step 2 — Compare Characters

For every pair of characters:

If they match:

```text
dp[i][j] = dp[i-1][j-1] + 1
```

Otherwise:

```text
dp[i][j] = max(
    dp[i-1][j],
    dp[i][j-1]
)
```

---

### Step 3 — Fill the Table

Example:

```text
String 1 : A G G T A B
String 2 : G X T X A Y B
```

The DP table is filled from the top-left corner toward the bottom-right corner.

Each cell depends only on previously computed values.

---

### Step 4 — Retrieve the Result

The value stored in the bottom-right corner represents the length of the Longest Common Subsequence.

```text
Length = dp[M][N]
```

Optionally, backtracking through the table reconstructs the actual subsequence.

---

## 💡 Dynamic Programming Principle

The LCS problem satisfies two important Dynamic Programming properties:

### Optimal Substructure

The optimal solution is built from optimal solutions to smaller subproblems.

---

### Overlapping Subproblems

Many character comparisons are repeated during recursion.

Dynamic Programming computes each subproblem only once and stores the result, avoiding redundant calculations.

---

## 📊 Complexity Analysis

| Complexity Type | Value |
|-----------------|-------|
| Time Complexity | O(M × N) |
| Space Complexity | O(M × N) |

Where:

- **M** = Length of the first string
- **N** = Length of the second string

---

## 🚀 Real-World Applications

The Longest Common Subsequence algorithm is widely used in:

- DNA and genome sequence analysis
- Version control systems (Git diff)
- File comparison tools
- Text similarity analysis
- Spell checking
- Plagiarism detection
- Natural Language Processing (NLP)

---

## 📚 Learning Outcomes

By building this project, you practice:

- Dynamic Programming
- Matrix tabulation
- String algorithms
- Optimal substructure
- Complexity analysis
- Problem decomposition
- Clean C# implementation

---

## 🔮 Future Improvements

Possible enhancements include:

- Reconstruct the actual LCS string
- Space-optimized Dynamic Programming
- Recursive solution with memoization
- Compare multiple strings
- Visualization of the DP table
- Unit testing with xUnit

---

## 📄 License

This project is created for educational purposes.