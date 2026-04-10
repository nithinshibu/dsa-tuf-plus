# 📘 Counting Digits in a Number (Optimized Approach)

## 🧠 Problem Summary

Given a number `n`, we need to find **how many digits are present** in
that number.

### Example:

- Input: `n = 12345`
- Output: `5`

---

## 💡 Intuition (Simple Thinking)

Normally, what we do is: - Keep dividing the number by 10 - Count how
many times we do it

But this takes **multiple steps (loop)**.

👉 Can we do it in **one shot**?

Yes! Using **logarithm (log10)**.

---

## 🚀 Optimized Idea

We use this formula:

    Number of digits in n = floor(log10(n)) + 1

### Why does this work?

- `log10(n)` tells us the **power of 10**
- Example:
  - log10(1) = 0 → 1 digit
  - log10(10) = 1 → 2 digits
  - log10(100) = 2 → 3 digits

So, 👉 `floor(log10(n)) + 1` gives total digits

---

## ⚠️ Edge Case

    n = 0

- log10(0) is undefined ❌
- But we know:
  - 0 has **1 digit**

So we handle it separately.

---

## 🧾 Code Explanation

```csharp
public int countDigit(int n) {
    // Edge case
    if (n == 0) return 1;

    int count = (int)Math.Floor(Math.Log10(n) + 1);
    return count;
}
```

### Step-by-step:

1.  Check if `n == 0`
    - Return 1 directly
2.  Apply formula:
    - `Math.Log10(n)` → gives logarithm
    - Add 1
    - Take `Floor` (to remove decimals)
3.  Return result

---

## 🔍 Dry Run

### Example: n = 1234

    log10(1234) ≈ 3.091
    floor(3.091 + 1) = floor(4.091) = 4

✅ Output = 4

---

### Example: n = 9

    log10(9) ≈ 0.95
    floor(0.95 + 1) = floor(1.95) = 1

✅ Output = 1

---

## ⏱️ Time Complexity

### O(1)

- We are **NOT using any loop**
- Only one mathematical operation

👉 Constant time

---

## 🧠 Space Complexity

### O(1)

- No extra memory used
- Just a variable to store result

---

## ⚖️ Comparison with Basic Approach

Approach Time Complexity Idea

---

Loop method O(log n) Divide by 10 repeatedly
Log method O(1) Direct mathematical formula

---

## 🧭 When to Use This?

Use this when: - You need **fast computation** - No iteration allowed -
Competitive programming / interviews

---

## 🎯 Key Takeaway

👉 Instead of iterating, **think mathematically**

    Digits = floor(log10(n)) + 1

---

## 🔁 Revision Notes (Quick Recall)

- What is problem? → Count digits
- Basic way? → Divide by 10
- Optimized? → Use log10
- Formula? → floor(log10(n)) + 1
- Edge case? → n = 0

---
