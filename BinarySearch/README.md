# 🔍 Binary Search Algorithm

A high-performance implementation of the **Binary Search** algorithm using **C#** and **.NET 8**.

This project demonstrates the **Divide and Conquer** strategy to efficiently locate a target element within a sorted array while maintaining excellent performance on large datasets.

The implementation focuses on:

- Efficient searching
- Clean algorithm design
- Iterative problem solving
- Performance optimization
- Understanding search boundaries

---

## 📖 Description

Binary Search is an efficient algorithm used to find an element in a **sorted array**.

Instead of checking every element one by one, the algorithm repeatedly divides the search space in half until the target value is found or the search range becomes empty.

Compared to Linear Search, Binary Search performs dramatically better on large datasets.

---

## ✨ Features

- Fast and efficient searching
- Iterative implementation using a `while` loop
- Clean and beginner-friendly code structure
- Handles "not found" cases correctly
- Optimized midpoint calculation to prevent integer overflow
- Demonstrates divide-and-conquer logic

---

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET 8
- **IDE:** Visual Studio 2022

---

## 📂 Project Structure

```text
BinarySearch/
├── Program.cs               # Entry point and algorithm implementation
├── BinarySearch.csproj      # Project configuration
└── BinarySearch.sln         # Solution file
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
git clone https://github.com/YourUsername/BinarySearch.git
```

---

### Run the Project

```bash
dotnet run
```

---

## 💻 Usage Example

```csharp
int[] array = { 1, 3, 5, 7, 9, 11 };

int result = BinarySearch(array, 7);

Console.WriteLine(result);
```

---

## 🖥️ Example Output

```text
3
```

The value `7` exists at index `3`.

---

## 🧠 Algorithm Explanation

The algorithm works by maintaining two pointers:

- `low` → Start of the search range
- `high` → End of the search range

At every iteration:

1. Calculate the midpoint
2. Compare the target with the middle element
3. Eliminate half of the remaining search space
4. Repeat until the target is found or the range becomes invalid

---

## 🔄 Binary Search Flow

### Initial Array

```text
[1, 3, 5, 7, 9, 11]
```

Searching for:

```text
7
```

### Step 1

```text
Middle Element = 5
```

Since `7 > 5`, search the right half.

---

### Step 2

```text
Middle Element = 9
```

Since `7 < 9`, search the left half.

---

### Step 3

```text
Middle Element = 7
```

Target found successfully.

---

## ⚠️ Important Requirement

Binary Search only works correctly if the array is already sorted.

Example:

✅ Valid:

```text
[1, 3, 5, 7, 9]
```

❌ Invalid:

```text
[7, 1, 9, 3, 5]
```

---

## 📊 Complexity Analysis

| Complexity Type | Value |
|-----------------|-------|
| Best Case Time  | O(1) |
| Average Time    | O(log n) |
| Worst Case Time | O(log n) |
| Space Complexity | O(1) |

---

## 🚀 Why Binary Search Matters

Binary Search is one of the most important searching algorithms because it:

- Performs extremely well on large datasets
- Reduces search operations dramatically
- Introduces divide-and-conquer thinking
- Is widely used in real-world systems and databases
- Forms the foundation for many advanced algorithms

---

## 📚 Learning Outcomes

By building this project, you practice:

- Divide-and-conquer problem solving
- Iterative algorithms
- Search optimization techniques
- Time complexity analysis
- Array indexing and boundaries
- Writing clean and efficient C# code

---

## 🔮 Future Improvements

Possible enhancements include:

- Recursive Binary Search implementation
- Generic type support using `IComparable`
- Descending-order support
- Interactive user input
- Benchmark comparison with Linear Search
- Unit testing with xUnit

---

## 📄 License

This project is created for educational purposes.