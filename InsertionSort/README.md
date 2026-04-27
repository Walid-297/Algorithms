# InsertionSort

A clean, modular implementation of the **Insertion Sort** algorithm using **C#** and **.NET 8**.  
This project demonstrates how insertion sort works internally while following clean code structure and standard software engineering practices.

---

# Description

Insertion Sort is a simple and intuitive sorting algorithm that builds the final sorted array one item at a time.

Although it is less efficient on large datasets compared to advanced algorithms like QuickSort or MergeSort, it performs very well for:
- Small collections
- Nearly sorted arrays
- Educational purposes

The algorithm works by repeatedly taking an element from the unsorted portion and inserting it into its correct position in the sorted portion.

---

# Features

- Clean and modular implementation
- Beginner-friendly code structure
- In-place sorting algorithm
- Low memory usage
- Well-organized project architecture
- Easy to understand and extend

---

# Technologies Used

- **Language:** C#
- **Framework:** .NET 8
- **IDE:** Visual Studio 2022

---

# Project Structure

```text
InsertionSort/
├── InsertionSort.csproj      # Project configuration
├── InsertionSort.sln         # Solution file
├── Program.cs                # Entry point and demonstration
└── InsertionSort.cs          # Core algorithm implementation
```

---

# Getting Started

## Prerequisites

Make sure you have installed:

- .NET 8 SDK
- Visual Studio 2022 or VS Code

---

## Clone the Repository

```bash
git clone https://github.com/YourUsername/InsertionSort.git
```

---

## Run the Project

```bash
dotnet run
```

---

# Usage Example

```csharp
int[] data = { 9, 5, 1, 4, 3 };

InsertionSort sorter = new InsertionSort();

sorter.Sort(data);

Console.WriteLine(string.Join(" ", data));
```

### Output

```text
1 3 4 5 9
```

---

# Algorithm Explanation

The algorithm sorts the array by dividing it into:
- A sorted portion
- An unsorted portion

Steps:

1. Start from the second element (index 1).
2. Store the current element as the key.
3. Compare the key with elements before it.
4. Shift larger elements one position to the right.
5. Insert the key into its correct position.
6. Repeat until the array becomes fully sorted.

---

# Complexity Analysis

|     Case     | Time Complexity |
|--------------|-----------------|
| Best Case    |       O(n)      |
| Average Case |       O(n²)     |
| Worst Case   |       O(n²)     |

### Space Complexity

```text
O(1)
```

Insertion Sort is an in-place sorting algorithm, meaning it does not require additional significant memory.

---

# When to Use Insertion Sort

Insertion Sort is useful when:

- The dataset is small
- The array is already partially sorted
- Memory usage must remain minimal
- Simplicity and readability are priorities

---

# Future Improvements

Possible future enhancements:

- Generic type support using `IComparable`
- Descending order sorting
- Benchmark comparison with other sorting algorithms
- Unit testing using xUnit
- Performance visualization

---

# License

This project is licensed under the MIT License.