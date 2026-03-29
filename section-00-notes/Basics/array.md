# 📘 Arrays — Complete Notes for DSA

---

# 🔹 What is an Array?

An **array** is a collection of elements stored in **contiguous memory locations**.

👉 All elements are of the **same type**
👉 Access is done using an **index (0-based)**

```csharp
int[] arr = new int[] {1, 2, 3, 4, 5};
```

---

# 🔹 Key Characteristics

| Property          | Description                  |
| ----------------- | ---------------------------- |
| Fixed Size        | Size defined at creation     |
| Indexed Access    | Access using index (0-based) |
| Contiguous Memory | Stored next to each other    |
| Fast Access       | O(1) time                    |

---

# 🔹 Time Complexity Basics

| Operation       | Complexity |
| --------------- | ---------- |
| Access          | O(1)       |
| Update          | O(1)       |
| Search          | O(n)       |
| Insert (end)    | O(1)       |
| Insert (middle) | O(n)       |
| Delete          | O(n)       |

---

# 🔹 Array Declaration in C#

```csharp
// Method 1
int[] arr = new int[5];

// Method 2
int[] arr = {1, 2, 3};

// Method 3
var arr = new int[] {1, 2, 3};
```

---

# 🔹 Basic Operations

## ✅ Access

```csharp
int value = arr[2];  // O(1)
```

## ✅ Update

```csharp
arr[2] = 10;  // O(1)
```

## ✅ Traversal

```csharp
for(int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
```

OR

```csharp
foreach(var num in arr)
{
    Console.WriteLine(num);
}
```

---

# 🔹 Common Patterns in DSA

---

## 🟢 1. Traversal Pattern

👉 Visit each element once

```csharp
for(int i = 0; i < arr.Length; i++)
{
    // process arr[i]
}
```

Used in:

- Sum of array
- Find max/min

---

## 🔵 2. Two Pointer Technique

👉 Use two indices (start & end)

```csharp
int left = 0;
int right = arr.Length - 1;

while(left < right)
{
    // process
    left++;
    right--;
}
```

Used in:

- Reverse array
- Pair sum problems
- Palindrome check

---

## 🟡 3. Sliding Window

👉 Maintain a window range

```csharp
int windowSum = 0;
int k = 3;

for(int i = 0; i < k; i++)
    windowSum += arr[i];

for(int i = k; i < arr.Length; i++)
{
    windowSum += arr[i];
    windowSum -= arr[i - k];
}
```

Used in:

- Subarray sum
- Maximum sum subarray of size k

---

## 🟠 4. Prefix Sum

👉 Store cumulative sums

```csharp
int[] prefix = new int[arr.Length];
prefix[0] = arr[0];

for(int i = 1; i < arr.Length; i++)
{
    prefix[i] = prefix[i - 1] + arr[i];
}
```

Used in:

- Range sum queries

---

## 🔴 5. Kadane’s Algorithm (Important)

👉 Maximum subarray sum

```csharp
int maxSum = arr[0];
int currentSum = arr[0];

for(int i = 1; i < arr.Length; i++)
{
    currentSum = Math.Max(arr[i], currentSum + arr[i]);
    maxSum = Math.Max(maxSum, currentSum);
}
```

---

# 🔹 Important Problem Types

## ✅ 1. Searching

- Linear Search → O(n)
- Binary Search (sorted array) → O(log n)

```csharp
int left = 0, right = arr.Length - 1;

while(left <= right)
{
    int mid = (left + right) / 2;

    if(arr[mid] == target) return mid;
    else if(arr[mid] < target) left = mid + 1;
    else right = mid - 1;
}
```

---

## ✅ 2. Sorting

Common algorithms:

- Bubble Sort → O(n²)
- Selection Sort → O(n²)
- Built-in sort → O(n log n)

```csharp
Array.Sort(arr);
```

---

## ✅ 3. Subarray Problems

👉 Continuous part of array

Examples:

- Maximum subarray
- Subarray with given sum

---

## ✅ 4. Rotation Problems

```csharp
// Right rotate by 1
int last = arr[arr.Length - 1];

for(int i = arr.Length - 1; i > 0; i--)
{
    arr[i] = arr[i - 1];
}
arr[0] = last;
```

---

## ✅ 5. Duplicate / Frequency Problems

👉 Use Dictionary

```csharp
var map = new Dictionary<int, int>();

foreach(var num in arr)
{
    if(map.ContainsKey(num))
        map[num]++;
    else
        map[num] = 1;
}
```

---

# 🔹 Important Tricks for Interviews

---

## ⚡ 1. Always Ask:

- Is array sorted?
- Can I modify the array?
- Is extra space allowed?

---

## ⚡ 2. Reduce Time Complexity

| Brute Force | Optimized                |
| ----------- | ------------------------ |
| O(n²)       | O(n) using Hashing       |
| O(n²)       | O(n log n) using sorting |

---

## ⚡ 3. Edge Cases

- Empty array
- Single element
- All same elements
- Negative numbers
- Large input

---

# 🔹 Arrays vs List in C#

| Feature     | Array        | List            |
| ----------- | ------------ | --------------- |
| Size        | Fixed        | Dynamic         |
| Performance | Faster       | Slight overhead |
| Use case    | DSA problems | Real apps       |

---

# 🔹 Space Complexity Concepts

| Case           | Complexity |
| -------------- | ---------- |
| No extra space | O(1)       |
| New array      | O(n)       |
| HashMap used   | O(n)       |

---

# 🔹 Common Mistakes

❌ Off-by-one errors
❌ Index out of bounds
❌ Not handling edge cases
❌ Using brute force when optimization exists

---

# 🔹 Final Summary

- Arrays = simplest & most important DSA structure
- Master patterns → not just syntax
- Focus on:
  - Traversal
  - Two pointers
  - Sliding window
  - Prefix sum
  - Hashing

---

# 🎯 Closing Thought

Most DSA problems are just **pattern recognition on arrays**

👉 If you master arrays, you unlock:

- Strings
- Sliding window
- Greedy
- Dynamic Programming

---
