# 🔀 Merge Sort Algorithm

A clean and educational implementation of the **Merge Sort** algorithm using **C#** and **.NET 8**.

This project demonstrates how the divide-and-conquer strategy works by recursively splitting arrays into smaller parts and merging them back together in sorted order.

The implementation focuses on:

- Algorithm clarity
- Recursive problem solving
- Clean code structure
- Understanding array manipulation
- Learning advanced sorting concepts

---

## 📖 Overview

Merge Sort is an efficient and stable sorting algorithm based on the **Divide and Conquer** paradigm.

The algorithm works by:

1. Dividing the array into two halves
2. Recursively sorting each half
3. Merging the sorted halves back together

Unlike simple algorithms such as Bubble Sort or Insertion Sort, Merge Sort performs efficiently even on large datasets.

---

## ✨ Features

- Recursive divide-and-conquer implementation
- Stable sorting algorithm
- Efficient performance on large datasets
- Clear separation between sorting and merging logic
- Beginner-friendly implementation with comments
- Demonstrates recursive thinking and array handling

---

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET 8
- **IDE:** Visual Studio 2022

---

## 📂 Project Structure

```text
MergeSort/
├── Program.cs              # Main application and algorithm implementation
├── MergeSort.csproj        # Project configuration
└── MergeSort.sln           # Solution file
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
git clone https://github.com/YourUsername/MergeSort.git
```

---

### Run the Project

```bash
dotnet run
```

---

## 💻 Usage Example

```csharp
int[] array = { 9, 5, 1, 4 };

Console.WriteLine(string.Join(", ", array));

MergeSort(array, 0, array.Length - 1);

Console.WriteLine(string.Join(", ", array));
```

---

## 🖥️ Example Output

```text
9, 5, 1, 4
1, 4, 5, 9
```

---

## 🧠 How Merge Sort Works

### Step 1 — Divide

The array is recursively divided into smaller halves until each sub-array contains only one element.

Example:

```text
[9, 5, 1, 4]

→ [9, 5]   [1, 4]

→ [9] [5]  [1] [4]
```

---

### Step 2 — Merge

The algorithm merges the smaller sorted arrays back together in the correct order.

Example:

```text
[9] [5] → [5, 9]

[1] [4] → [1, 4]

[5, 9] [1, 4] → [1, 4, 5, 9]
```

---

## 🔄 Recursive Flow

The `MergeSort()` method:

- Finds the midpoint
- Calls itself recursively on the left half
- Calls itself recursively on the right half
- Merges both sorted halves

The `Merge()` method:

- Creates temporary arrays
- Compares elements from both halves
- Places elements back into the original array in sorted order

---

## 🔄 Call Stack example

MergeSort(0, 3)
├── MergeSort(0, 1)
│   ├── MergeSort(0, 0)
│   └── MergeSort(1, 1)
└── MergeSort(2, 3)
    ├── MergeSort(2, 2)
    └── MergeSort(3, 3)
---

## 📊 Complexity Analysis

| Complexity Type | Value |
|-----------------|-------|
| Best Case Time  | O(n log n) |
| Average Time    | O(n log n) |
| Worst Case Time | O(n log n) |
| Space Complexity | O(n) |

---

## 🚀 Why Merge Sort Matters

Merge Sort is important because it:

- Performs consistently well on large datasets
- Introduces divide-and-conquer concepts
- Builds strong recursion skills
- Is used as the foundation for advanced algorithms
- Demonstrates efficient algorithm design

---

## 📚 Learning Outcomes

By building this project, you practice:

- Recursion
- Divide-and-conquer techniques
- Array manipulation
- Algorithm analysis
- Time and space complexity understanding
- Writing clean and modular C# code

---

## 🔮 Future Improvements

Possible enhancements include:

- Generic type support using `IComparable`
- Descending order sorting
- Interactive console input
- Benchmark comparison with other sorting algorithms
- Unit testing with xUnit
- Visual representation of the merge process

---

## 📄 License

This project is created for educational purposes.