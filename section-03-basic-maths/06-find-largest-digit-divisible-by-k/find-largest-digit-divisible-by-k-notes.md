# Largest Digit Divisible by K (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given an integer `n` and a number `k`, find the **largest digit in `n` that is divisible by `k`**.

If no such digit exists, return `-1`.

---

## 📌 Examples

- Input: `n = 5382, k = 2` → Output: `8`
- Input: `n = 1234, k = 5` → Output: `-1`

---

## 💡 Intuition (Very Simple Thinking)

👉 We need to:
1. Check every digit
2. Only consider digits divisible by `k`
3. Among those, pick the largest

---

## 🔁 Core Idea

- Extract digit → `% 10`
- Check → `digit % k == 0`
- Track max among valid digits
- Remove digit → `/ 10`

---

## ⚙️ Step-by-Step Execution

### Input:
```
n = 5382, k = 2
```

### Initial:
- result = -1

---

### Iteration 1:
- digit = 2
- 2 % 2 == 0 ✅
- result = max(-1, 2) = 2
- n = 538

### Iteration 2:
- digit = 8
- 8 % 2 == 0 ✅
- result = max(2, 8) = 8
- n = 53

### Iteration 3:
- digit = 3
- 3 % 2 != 0 ❌ skip
- n = 5

### Iteration 4:
- digit = 5
- 5 % 2 != 0 ❌ skip
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
    public int LargestDigitDivisibleByK(int n, int k)
    {
        n = Math.Abs(n);

        int result = -1;

        while (n > 0)
        {
            int digit = n % 10;

            if (digit % k == 0)
            {
                if (digit > result)
                {
                    result = digit;
                }
            }

            n = n / 10;
        }

        return result;
    }
}
```

---

## 🎯 Key Insight

👉 This combines two patterns:
- Filter condition (`digit % k == 0`)
- Track maximum value

---

## 🧮 Time Complexity (Detailed)

Let number of digits = `d`

- Loop runs `d` times
- Each step constant work

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
- result
- digit
- n

```
Space Complexity = O(1)
```

---

## ⚠️ Edge Cases

1. No digit divisible by k → return -1
2. Negative numbers → handled using Math.Abs()
3. k = 0 ❌ (invalid, division by zero)

---

## 🔄 How to Think During Revision

When you see this problem:

1. "Check every digit"
2. "Apply condition → divisible by k"
3. "Track maximum among valid digits"

---

## 🧩 Summary (Quick Recall)

- Extract → `% 10`
- Check → `% k == 0`
- Track max
- Return result or -1

---

## 🚀 Final Mental Model

👉 “Filter + Track Maximum”

---

## 🔁 Pattern Connection

This problem is a combination of:
- Digit extraction
- Conditional filtering
- Maximum tracking

Used in:
- Filtered max/min problems
- Constraint-based digit problems
