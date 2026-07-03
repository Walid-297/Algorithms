# 🔤 Sorted Characters Frequencies

A clean and educational implementation of an **ASCII Character Frequency Counter** using **C#** and **.NET 8**.

This project demonstrates how to efficiently count character frequencies using a **Direct Addressing (Frequency Table)** technique instead of dictionaries or explicit sorting algorithms.

The implementation focuses on:

- Character frequency analysis
- Direct memory indexing
- ASCII representation
- Efficient counting techniques
- Simple and clean algorithm design

---

## 📖 Overview

The program analyzes a string and determines how many times each character appears.

Instead of storing characters in a dictionary, it uses a fixed-size integer array where each array index directly represents an ASCII character code.

After counting, the algorithm scans the frequency table from beginning to end, producing the output in natural ASCII order without performing any sorting operation.

---

## ✨ Features

- Direct Addressing technique
- ASCII-based frequency table
- Automatic sorted output
- Constant-size memory allocation
- Fast linear-time processing
- Beginner-friendly implementation

---

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET 8
- **IDE:** Visual Studio 2022

---

## 📂 Project Structure

```text
SortedCharactersFrequencies/
├── CharFreq.cs                     # Character frequency implementation
├── Program.cs                      # Application entry point
├── SortedCharactersFrequencies.csproj
└── SortedCharactersFrequencies.sln
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
git clone https://github.com/YourUsername/SortedCharactersFrequencies.git
```

---

### Run the Project

```bash
dotnet run
```

---

## 💻 Usage Example

```csharp
string message = "Hello World";

CharFreq counter = new CharFreq();

counter.PrintFrequency(message);
```

---

## 🖥️ Example Output

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

The output is automatically ordered according to the ASCII table.

---

## 🧠 How the Algorithm Works

The algorithm consists of two simple passes.

### Step 1 — Create the Frequency Table

Allocate an integer array with one position for every ASCII character.

```text
int[] frequency = new int[127];
```

Each index represents an ASCII code.

Example:

```text
Index 65 → 'A'
Index 97 → 'a'
```

---

### Step 2 — Count Characters

For every character in the input string:

1. Convert the character into its ASCII code.
2. Use that code as an array index.
3. Increment the value stored at that position.

Example:

```text
Message

Hello
```

Processing:

```text
'H' → frequency[72]++

'e' → frequency[101]++

'l' → frequency[108]++

'l' → frequency[108]++

'o' → frequency[111]++
```

---

### Step 3 — Display Results

Loop through the frequency table from index `0` to `126`.

Whenever an entry is greater than zero:

- Convert the index back into its character.
- Print the character and its frequency.

Because the table is scanned sequentially, the output is automatically sorted according to the ASCII table.

---

## 📊 Complexity Analysis

| Complexity Type | Value |
|-----------------|-------|
| Counting | O(n) |
| Printing | O(127) ≈ O(1) |
| Overall Time Complexity | O(n) |
| Space Complexity | O(1) |

> The frequency array has a fixed size (127 elements), so its memory usage does not grow with the input size.

---

## 🚀 Why This Technique Matters

Direct Addressing is an efficient technique whenever the range of possible keys is small and known in advance.

It avoids:

- Dictionary lookups
- Hashing overhead
- Explicit sorting algorithms

This makes it extremely fast for problems involving:

- Character counting
- Histograms
- Frequency analysis
- Counting sort
- Text processing

---

## 📚 Learning Outcomes

By building this project, you practice:

- ASCII character encoding
- Direct Addressing
- Frequency tables
- Array indexing
- Algorithm complexity analysis
- Efficient data processing in C#

---

## 🔮 Future Improvements

Possible enhancements include:

- Full Unicode support
- Case-insensitive counting
- Ignore whitespace and punctuation
- Letter frequency percentages
- Graphical histogram output
- Unit testing with xUnit

---

## 📄 License

This project is created for educational purposes.