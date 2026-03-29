# 📘 Big O Notation — Complete Quick Revision Guide

## 🔹 What is Big O Notation?

Big O Notation is used to describe the **performance or complexity** of an algorithm in terms of:

- **Time Complexity** → How execution time grows with input size `n`
- **Space Complexity** → How memory usage grows with input size `n`

👉 It focuses on the **worst-case scenario**
👉 It ignores constants and lower-order terms

---

## 🔹 Why Big O Matters in Interviews?

Interviewers expect you to:

- Analyze efficiency
- Compare approaches
- Optimize brute-force solutions
- Communicate clearly

---

## 🔹 Common Complexity Classes (Ordered)

| Complexity | Name         | Efficiency   |
| ---------- | ------------ | ------------ |
| O(1)       | Constant     | 🚀 Best      |
| O(log n)   | Logarithmic  | ⚡ Very Good |
| O(√n)      | Root         | 👍 Good      |
| O(n)       | Linear       | ⚖️ Moderate  |
| O(n log n) | Linearithmic | 🧠 Efficient |
| O(n²)      | Quadratic    | ❌ Slow      |

---

# 🟢 1. O(1) — Constant Time

## 📌 Definition

Execution time **does not depend on input size**

## 🧠 Intuition

No matter how big `n` is, operation takes the same time

## 💡 Examples

```python
arr[5]          # Access by index
x = a + b       # Simple operation
dict[key]       # Hash lookup (average case)
```

## ⏱ Time Complexity

- Always constant

## 📦 Space Complexity

- Constant space (if no extra memory grows)

---

# 🔵 2. O(log n) — Logarithmic Time

## 📌 Definition

Problem size is **reduced by half each step**

## 🧠 Intuition

Divide and conquer approach

## 💡 Examples

```python
# Binary Search
while left <= right:
    mid = (left + right) // 2
```

## 📊 Growth

- n = 1,000 → ~10 steps
- n = 1,000,000 → ~20 steps

## ⏱ Time Complexity

- Very efficient for large inputs

## 📦 Space Complexity

- Usually O(1) or O(log n) (recursive)

---

# 🟡 3. O(√n) — Square Root Time

## 📌 Definition

Runs in proportional to square root of input

## 🧠 Intuition

You don't need to check all elements

## 💡 Examples

```python
# Checking if a number is prime
for i in range(2, int(n**0.5) + 1):
```

## 📊 Growth

- n = 1,000,000 → ~1,000 steps

## ⏱ Time Complexity

- Faster than linear for large inputs

---

# 🟠 4. O(n) — Linear Time

## 📌 Definition

Execution time grows **directly proportional** to input size

## 🧠 Intuition

You must visit every element

## 💡 Examples

```python
for i in arr:
    print(i)
```

## 📊 Growth

- n = 10 → 10 steps
- n = 1000 → 1000 steps

## ⏱ Time Complexity

- Acceptable for most problems

## 📦 Space Complexity

- Depends on usage (can be O(1) or O(n))

---

# 🔵 5. O(n log n) — Linearithmic Time

## 📌 Definition

Combination of **linear and logarithmic**

## 🧠 Intuition

Divide + process all elements

## 💡 Examples

```python
# Merge Sort / Quick Sort (average)
sort(arr)
```

## 📊 Growth

- Faster than O(n²)
- Standard for efficient sorting

## ⏱ Time Complexity

- Best practical complexity for sorting

---

# 🔴 6. O(n²) — Quadratic Time

## 📌 Definition

Nested loops over input

## 🧠 Intuition

For each element, you process all others

## 💡 Examples

```python
for i in range(n):
    for j in range(n):
        print(i, j)
```

## 📊 Growth

- n = 1000 → 1,000,000 operations

## ⏱ Time Complexity

- Very slow for large inputs

## 📦 Space Complexity

- Usually O(1)

---

# 🔹 Quick Comparison

| n         | O(1) | O(log n) | O(n) | O(n log n) | O(n²)     |
| --------- | ---- | -------- | ---- | ---------- | --------- |
| 10        | 1    | 3        | 10   | 30         | 100       |
| 1000      | 1    | 10       | 1000 | 10,000     | 1,000,000 |
| 1,000,000 | 1    | 20       | 1M   | 20M        | 1T        |

---

# 🔹 Key Interview Tips

## ✅ Always Mention:

- Time Complexity
- Space Complexity
- Why it's optimal

## ✅ Use This Structure:

> “This solution runs in O(n log n) time because we divide the array and process each level, and uses O(n) space due to auxiliary arrays.”

## ❌ Avoid:

- Ignoring worst case
- Saying "fast" instead of explaining
- Missing space complexity

---

# 🔹 Final Summary

| Complexity | When You See It            |
| ---------- | -------------------------- |
| O(1)       | Direct access, hash lookup |
| O(log n)   | Binary search, trees       |
| O(√n)      | Math problems, factors     |
| O(n)       | Single loop                |
| O(n log n) | Sorting, divide & conquer  |
| O(n²)      | Nested loops               |

---

# 🎯 Closing Thought

Understanding Big O is not about memorizing —
it's about **recognizing patterns in problems**.

> The more problems you solve, the faster you identify complexity.

---

That’s a wrap 🎯
If this helped you, ❤️ Retweet or bookmark this for later.
