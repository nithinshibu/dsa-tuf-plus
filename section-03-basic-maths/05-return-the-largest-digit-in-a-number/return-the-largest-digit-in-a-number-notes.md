# Largest Digit in a Number (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given an integer `n`, find the **largest digit** in that number.

### Examples:
- Input: `5382` → Output: `8`
- Input: `9071` → Output: `9`

---

## 💡 Intuition (Very Simple Thinking)

👉 The number is made up of digits.

We need to:
1. Check each digit one by one
2. Keep track of the biggest digit seen so far

---

## 🔁 Core Idea

- Extract last digit → `% 10`
- Compare with current largest
- Update if bigger
- Remove digit → `/ 10`

---

## ⚙️ Step-by-Step Execution

### Input:
```
n = 5382
```

### Initial:
- largestDigit = 0

---

### Iteration 1:
- lastDigit = 2
- largestDigit = max(0, 2) = 2
- n = 538

### Iteration 2:
- lastDigit = 8
- largestDigit = max(2, 8) = 8
- n = 53

### Iteration 3:
- lastDigit = 3
- largestDigit = max(8, 3) = 8
- n = 5

### Iteration 4:
- lastDigit = 5
- largestDigit = max(8, 5) = 8
- n = 0 → stop

---

### Final Answer:
```
8
```

---

## 🧾 Final Code (C#)

```csharp
using System;

public class Solution
{
    public int LargestDigit(int n)
    {
        int largestDigit = 0;

        while (n > 0)
        {
            int lastDigit = n % 10;

            if (lastDigit > largestDigit)
            {
                largestDigit = lastDigit;
            }

            n /= 10;
        }

        return largestDigit;
    }
}
```

---

## 🎯 Key Insight

👉 Always keep track of the **best value seen so far**

This is a very common pattern:
- Max element
- Min element
- Best answer tracking

---

## 🧮 Time Complexity (Detailed)

Let number of digits = `d`

- Loop runs `d` times
- Each step → constant work

```
Time Complexity = O(d)
```

Since `d ≈ log₁₀(n)`:
```
Time Complexity = O(log n)
```

---

## 💾 Space Complexity (Detailed)

We only use:
- largestDigit
- lastDigit
- n

No extra memory.

```
Space Complexity = O(1)
```

---

## ⚠️ Common Mistakes

1. ❌ Not initializing largestDigit properly
2. ❌ Forgetting to update condition
3. ❌ Not iterating through all digits

---

## 🔄 How to Think During Revision

When you see this problem:

1. "I need to check every digit"
2. "I need to track maximum"
3. "Compare and update"

---

## 🧩 Summary (Quick Recall)

- Extract digit → `% 10`
- Compare → update max
- Remove digit → `/ 10`
- Repeat

---

## 🚀 Final Mental Model

👉 “Scan digits and keep the maximum”

---

## 🔁 Pattern Connection

This is part of a common pattern:
- Digit extraction problems

Used in:
- Largest digit
- Smallest digit
- Sum of digits
- Count digits
