# LCM (Least Common Multiple) using GCD – Detailed Revision Notes

## 🧠 Problem Statement
Given two integers `n1` and `n2`, find their **LCM (Least Common Multiple)**.

👉 LCM is the smallest number that is divisible by both numbers.

---

## 📌 Examples

- Input: `n1 = 4, n2 = 6` → Output: `12`
- Input: `n1 = 5, n2 = 7` → Output: `35`

---

## 💡 Intuition (Very Simple Thinking)

👉 Instead of finding multiples (slow), we use a formula:

```
LCM(a, b) = (a × b) / GCD(a, b)
```

So:
1. Find GCD
2. Use formula to compute LCM

---

## 🔁 Core Idea

- Compute GCD using Euclidean Algorithm
- Use formula → `(n1 * n2) / gcd`

---

## ⚙️ Step-by-Step Execution

### Input:
```
n1 = 4, n2 = 6
```

### Step 1: Find GCD
- GCD(4, 6) = 2

### Step 2: Apply formula
```
LCM = (4 × 6) / 2 = 24 / 2 = 12
```

---

## 🧾 Final Code (C#)

```csharp
using System;

public class Solution
{
    private int GCD(int n1, int n2)
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

    public int LCM(int n1, int n2)
    {
        int gcd = this.GCD(n1, n2);

        long lcm = (long)n1 * n2 / gcd;

        return (int)lcm;
    }
}
```

---

## 🎯 Key Insight

👉 The powerful formula:
```
LCM × GCD = n1 × n2
```

---

## 🧮 Time Complexity (Detailed)

- GCD → O(log(min(n1, n2)))
- LCM calculation → O(1)

```
Total Time Complexity = O(log(min(n1, n2)))
```

---

## 💾 Space Complexity (Detailed)

We only use:
- few variables

```
Space Complexity = O(1)
```

---

## ⚠️ Edge Cases

1. If one number is 0 → LCM = 0
2. Large numbers → use long to avoid overflow
3. Negative numbers → take absolute value

---

## ⚠️ Common Mistakes

1. ❌ Using brute force (very slow)
2. ❌ Integer overflow
3. ❌ Forgetting GCD formula

---

## 🔄 How to Think During Revision

When you see this problem:

1. "LCM is related to GCD"
2. "Use formula"
3. "Compute GCD first"

---

## 🧩 Summary (Quick Recall)

- Find GCD
- Apply formula
- Return result

---

## 🚀 Final Mental Model

👉 “Multiply and divide by GCD”

---

## 🔁 Pattern Connection

This problem uses:
- GCD (Euclidean algorithm)
- Mathematical formula

Used in:
- Fractions
- Number theory
- Scheduling problems
