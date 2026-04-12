# Factorial of a Number (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given an integer `n`, find its factorial.

👉 Factorial of a number is:
```
n! = n × (n-1) × (n-2) × ... × 1
```

---

## 📌 Examples

- Input: `n = 5` → Output: `120`
- Input: `n = 3` → Output: `6`
- Input: `n = 0` → Output: `1`

---

## 💡 Intuition (Very Simple Thinking)

👉 Factorial means:
“Multiply all numbers from 1 to n”

Example:
```
5! = 1 × 2 × 3 × 4 × 5
```

---

## 🔁 Core Idea

- Start with `fact = 1`
- Multiply every number from `1 → n`
- Keep updating result

---

## ⚙️ Step-by-Step Execution

### Input:
```
n = 5
```

### Initial:
- fact = 1

---

### Iteration 1:
- fact = 1 × 1 = 1

### Iteration 2:
- fact = 1 × 2 = 2

### Iteration 3:
- fact = 2 × 3 = 6

### Iteration 4:
- fact = 6 × 4 = 24

### Iteration 5:
- fact = 24 × 5 = 120

---

### Final Answer:
```
120
```

---

## 🧾 Final Code (C#)

```csharp
using System;

public class Solution
{
    public int Factorial(int n)
    {
        if (n == 0) return 1;

        int fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }

        return fact;
    }
}
```

---

## 🎯 Key Insight

👉 This is a **multiplication accumulation pattern**

Similar to:
- Sum of numbers → addition
- Factorial → multiplication

---

## 🧮 Time Complexity (Detailed)

Loop runs from `1 → n`

```
Time Complexity = O(n)
```

Each step does constant work.

---

## 💾 Space Complexity (Detailed)

We only use:
- fact
- i

```
Space Complexity = O(1)
```

---

## ⚠️ Edge Cases

1. n = 0 → return 1
2. Large n → may cause integer overflow

---

## ⚠️ Common Mistakes

1. ❌ Forgetting base case (0! = 1)
2. ❌ Starting from 0 (wrong)
3. ❌ Overflow not considered

---

## 🔄 How to Think During Revision

When you see this problem:

1. "Factorial = multiply from 1 to n"
2. "Use loop"
3. "Keep updating result"

---

## 🧩 Summary (Quick Recall)

- Start with 1
- Multiply till n
- Return result

---

## 🚀 Final Mental Model

👉 “Multiply all numbers from 1 to n”

---

## 🔁 Pattern Connection

This problem uses:
- Accumulation pattern

Used in:
- Factorial
- Permutations & combinations
- Math problems
