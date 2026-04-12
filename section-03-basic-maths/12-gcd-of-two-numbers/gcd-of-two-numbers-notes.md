# GCD (Greatest Common Divisor) – Detailed Revision Notes

## 🧠 Problem Statement
Given two integers `n1` and `n2`, find their **GCD (Greatest Common Divisor)**.

👉 GCD is the largest number that divides both numbers.

---

## 📌 Examples

- Input: `n1 = 12, n2 = 18` → Output: `6`
- Input: `n1 = 20, n2 = 8` → Output: `4`

---

## 💡 Intuition (Very Simple Thinking)

👉 Instead of checking all divisors (slow), we use a smart trick:

```
GCD(a, b) = GCD(a % b, b)
```

This keeps reducing the numbers until one becomes 0.

---

## 🔁 Core Idea (Euclidean Algorithm)

- Replace larger number with remainder
- Keep repeating
- When one becomes 0 → other is GCD

---

## ⚙️ Step-by-Step Execution

### Input:
```
n1 = 12, n2 = 18
```

### Iteration 1:
- n2 > n1 → n2 = 18 % 12 = 6

### Iteration 2:
- n1 > n2 → n1 = 12 % 6 = 0

---

### Final:
```
GCD = 6
```

---

## 🧾 Final Code (C#)

```csharp
using System;

public class Solution
{
    public int GCD(int n1, int n2)
    {
        while (n1 > 0 && n2 > 0)
        {
            if (n1 > n2)
            {
                n1 = n1 % n2;
            }
            else
            {
                n2 = n2 % n1;
            }
        }

        if (n1 == 0) return n2;
        return n1;
    }
}
```

---

## 🎯 Key Insight

👉 The magic line:
```
a = a % b
```

This reduces problem size FAST.

---

## 🧮 Time Complexity (Detailed)

Each step reduces numbers significantly.

```
Time Complexity = O(log(min(n1, n2)))
```

Very efficient!

---

## 💾 Space Complexity (Detailed)

We only use:
- n1, n2

```
Space Complexity = O(1)
```

---

## ⚠️ Edge Cases

1. One number is 0 → return other
2. Both same → GCD is number itself
3. Negative numbers → take absolute value

---

## ⚠️ Common Mistakes

1. ❌ Using brute force (slow)
2. ❌ Division by zero (wrong condition)
3. ❌ Not understanding modulo logic

---

## 🔄 How to Think During Revision

When you see this problem:

1. "Use Euclidean algorithm"
2. "Reduce using modulo"
3. "Stop when one becomes 0"

---

## 🧩 Summary (Quick Recall)

- While both > 0
- Replace bigger with remainder
- Return non-zero number

---

## 🚀 Final Mental Model

👉 “Keep reducing using remainder until one becomes zero”

---

## 🔁 Pattern Connection

This problem uses:
- Mathematical reduction
- Optimization thinking

Used in:
- GCD
- LCM
- Fraction simplification
