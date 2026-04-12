# Count Odd Numbers in an Array (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given an array `arr` of size `n`, count how many elements are **odd numbers**.

---

## 📌 Examples

- Input: `[1, 2, 3, 4, 5]` → Output: `3`  
  (Odd numbers: 1, 3, 5)

- Input: `[2, 4, 6]` → Output: `0`

---

## 💡 Intuition (Very Simple Thinking)

👉 We need to:
1. Look at each element
2. Check if it is odd
3. Count it if true

---

## 🔁 Core Idea

- Loop through array
- Check → `number % 2 != 0`
- Increment count

---

## ⚙️ Step-by-Step Execution

### Input:
```
arr = [1, 2, 3, 4, 5]
```

### Initial:
- count = 0

---

### Iteration 1:
- 1 % 2 != 0 → odd ✅  
- count = 1

### Iteration 2:
- 2 % 2 == 0 → not odd ❌

### Iteration 3:
- 3 % 2 != 0 → odd ✅  
- count = 2

### Iteration 4:
- 4 % 2 == 0 → not odd ❌

### Iteration 5:
- 5 % 2 != 0 → odd ✅  
- count = 3

---

### Final Answer:
```
3
```

---

## 🧾 Final Code (C#)

```csharp
using System;

public class Solution
{
    public int countOdd(int[] arr, int n)
    {
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] % 2 != 0)
            {
                count++;
            }
        }

        return count;
    }
}
```

---

## 🎯 Key Insight

👉 Odd number check:
```
number % 2 != 0
```

---

## 🧮 Time Complexity (Detailed)

Loop runs `n` times:
```
Time Complexity = O(n)
```

---

## 💾 Space Complexity (Detailed)

We only use:
- count variable

```
Space Complexity = O(1)
```

---

## ⚠️ Edge Cases

1. Empty array → count = 0  
2. All even numbers → count = 0  
3. Negative odd numbers → still valid (e.g., -3 is odd)

---

## ⚠️ Common Mistakes

1. ❌ Using wrong condition (e.g., `% 2 == 1` fails for negatives)  
2. ❌ Not iterating full array  
3. ❌ Confusing odd/even logic  

---

## 🔄 How to Think During Revision

When you see this problem:

1. "Traverse array"
2. "Check condition (odd)"
3. "Count valid elements"

---

## 🧩 Summary (Quick Recall)

- Loop array  
- Check `% 2 != 0`  
- Count  

---

## 🚀 Final Mental Model

👉 “Filter elements based on condition and count”

---

## 🔁 Pattern Connection

This problem uses:
- Array traversal  
- Conditional filtering  
- Counting pattern  

Used in:
- Count positives/negatives  
- Count even/odd  
- Filter-based problems  
