# Sum of Array Elements (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given an array `arr` of size `n`, find the **sum of all elements**.

---

## 📌 Examples

- Input: `[1, 2, 3, 4]` → Output: `10`
- Input: `[5, 10, 15]` → Output: `30`

---

## 💡 Intuition (Very Simple Thinking)

👉 We need to:
- Visit every element
- Keep adding it to a running total

---

## 🔁 Core Idea

- Start with `sum = 0`
- Loop through array
- Add each element

---

## ⚙️ Step-by-Step Execution

### Input:
```
arr = [1, 2, 3, 4]
```

### Initial:
- sum = 0

---

### Iteration 1:
- sum = 0 + 1 = 1

### Iteration 2:
- sum = 1 + 2 = 3

### Iteration 3:
- sum = 3 + 3 = 6

### Iteration 4:
- sum = 6 + 4 = 10

---

### Final Answer:
```
10
```

---

## 🧾 Final Code (C#)

```csharp
using System;

public class Solution
{
    public int sum(int[] arr, int n)
    {
        int ans = 0;

        for (int i = 0; i < n; i++)
        {
            ans = ans + arr[i];
        }

        return ans;
    }
}
```

---

## 🎯 Key Insight

👉 This is a **basic accumulation pattern**

- Addition accumulation
- Similar to factorial (but multiplication)

---

## 🧮 Time Complexity (Detailed)

Loop runs `n` times:
```
Time Complexity = O(n)
```

---

## 💾 Space Complexity (Detailed)

We only use:
- ans variable

```
Space Complexity = O(1)
```

---

## ⚠️ Edge Cases

1. Empty array → sum = 0
2. Negative numbers → handled automatically
3. Large numbers → possible overflow

---

## ⚠️ Common Mistakes

1. ❌ Forgetting initialization (sum = 0)
2. ❌ Off-by-one error in loop
3. ❌ Ignoring array bounds

---

## 🔄 How to Think During Revision

When you see this problem:

1. "Visit every element"
2. "Keep adding"
3. "Return total"

---

## 🧩 Summary (Quick Recall)

- Initialize sum = 0
- Loop through array
- Add each element

---

## 🚀 Final Mental Model

👉 “Scan array and accumulate sum”

---

## 🔁 Pattern Connection

This problem uses:
- Linear traversal
- Accumulation pattern

Used in:
- Sum problems
- Average calculation
- Prefix sum problems
