# Find All Divisors of a Number (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given an integer `n`, return **all divisors of n**.

👉 A divisor is a number that divides `n` completely (no remainder).

---

## 📌 Examples

- Input: `n = 12`  
  Output: `[1, 2, 3, 4, 6, 12]`

- Input: `n = 7`  
  Output: `[1, 7]`

---

## 💡 Intuition (Very Simple Thinking)

👉 A divisor means:
```
n % i == 0
```

So basic idea:
- Try all numbers from `1 → n`
- If divisible → add to list

❌ But this is slow → O(n)

---

## ⚡ Optimization (VERY IMPORTANT)

👉 Key observation:
Divisors come in **pairs**

Example:
```
n = 12

1 × 12
2 × 6
3 × 4
```

👉 So instead of checking till `n`, we only check till `√n`

---

## 🔁 Core Idea

- Loop from `1 → √n`
- If `i` divides `n`:
  - Add `i`
  - Add `n/i` (pair)
- Avoid duplicates
- Sort at the end

---

## ⚙️ Step-by-Step Execution

### Input:
```
n = 12
```

### sqrt(n):
```
√12 ≈ 3
```

---

### Iteration 1:
- i = 1
- 12 % 1 == 0 ✅
- Add 1 and 12

List → [1, 12]

---

### Iteration 2:
- i = 2
- 12 % 2 == 0 ✅
- Add 2 and 6

List → [1, 12, 2, 6]

---

### Iteration 3:
- i = 3
- 12 % 3 == 0 ✅
- Add 3 and 4

List → [1, 12, 2, 6, 3, 4]

---

### Sort:
```
[1, 2, 3, 4, 6, 12]
```

---

## 🧾 Final Code (C#)

```csharp
using System;
using System.Collections.Generic;

class Solution
{
    public List<int> divisors(int n)
    {
        List<int> ans = new List<int>();

        int sqrtN = (int)Math.Sqrt(n);

        for (int i = 1; i <= sqrtN; i++)
        {
            if (n % i == 0)
            {
                ans.Add(i);

                if (i != n / i)
                {
                    ans.Add(n / i);
                }
            }
        }

        ans.Sort();
        return ans;
    }
}
```

---

## 🎯 Key Insight

👉 The trick:
```
Divisors always come in pairs
```

👉 So:
- Check only till √n
- Add both numbers

---

## 🧮 Time Complexity (Detailed)

Loop runs till √n:
```
O(√n)
```

Sorting:
```
O(k log k)   (k = number of divisors)
```

👉 Final:
```
O(√n + k log k)
```

---

## 💾 Space Complexity (Detailed)

We store all divisors:
```
O(k)
```

Where `k` = number of divisors

---

## ⚠️ Edge Cases

1. n = 1 → [1]
2. Perfect square (like 36):
   - Avoid duplicate (6 added twice)
3. Large n → many divisors

---

## ⚠️ Common Mistakes

1. ❌ Loop till n (slow)
2. ❌ Forgetting divisor pair
3. ❌ Duplicate values for perfect squares
4. ❌ Not sorting output

---

## 🔄 How to Think During Revision

When you see this problem:

1. "Divisors come in pairs"
2. "Loop till √n"
3. "Add both i and n/i"
4. "Avoid duplicates"
5. "Sort result"

---

## 🧩 Summary (Quick Recall)

- Loop → 1 to √n
- If divisible:
  - Add i
  - Add n/i
- Sort

---

## 🚀 Final Mental Model

👉 “Find divisor pairs till √n and sort them”

---

## 🔁 Pattern Connection

This problem uses:
- Divisor pattern
- √n optimization
- Pair logic

Used in:
- Factor problems
- Perfect numbers
- Prime checks
