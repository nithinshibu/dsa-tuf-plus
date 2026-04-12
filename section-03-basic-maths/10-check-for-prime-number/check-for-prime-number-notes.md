# Prime Number Check (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given an integer `n`, check whether it is a **prime number**.

👉 A prime number:
- Has exactly **2 divisors** → `1` and `n`
- Example: 2, 3, 5, 7, 11

---

## 📌 Examples

- Input: `n = 7` → Output: `true`
- Input: `n = 10` → Output: `false`

---

## 💡 Intuition (Very Simple Thinking)

👉 To check if a number is prime:
- Try dividing it by numbers from `2 → n-1`
- If any number divides it → NOT prime
- If none divides → prime

---

## ⚡ Optimization (IMPORTANT)

👉 Instead of checking till `n-1`, we check till `√n`

Why?

Because divisors come in pairs:
```
n = a × b
```

If one factor is small, the other is large.

So checking till √n is enough.

---

## 🔁 Example Walkthrough

### Input:
```
n = 10
```

Check:
- 10 % 2 == 0 → divisible ❌

So → NOT prime

---

### Input:
```
n = 7
```

Check:
- 7 % 2 != 0
- 7 % 3 != 0

No divisors → PRIME ✅

---

## 🧾 Final Code (C#)

```csharp
using System;

class Solution
{
    public bool IsPrime(int n)
    {
        if (n < 2) return false;

        for (int i = 2; i * i <= n; ++i)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
```

---

## 🎯 Key Insight

👉 If a number has a divisor, it will appear before √n

---

## 🧮 Time Complexity (Detailed)

Loop runs from `2 → √n`

```
Time Complexity = O(√n)
```

Much better than O(n)

---

## 💾 Space Complexity (Detailed)

We only use:
- loop variable

```
Space Complexity = O(1)
```

---

## ⚠️ Edge Cases

1. n < 2 → not prime
2. n = 2 → prime
3. Large n → optimization required

---

## ⚠️ Common Mistakes

1. ❌ Checking till n (slow)
2. ❌ Not handling n < 2
3. ❌ Incorrect loop condition

---

## 🔄 How to Think During Revision

When you see this problem:

1. "Check divisibility"
2. "Use sqrt optimization"
3. "Stop early if divisor found"

---

## 🧩 Summary (Quick Recall)

- Loop till √n
- If divisible → false
- Else → true

---

## 🚀 Final Mental Model

👉 “Check divisors till √n”

---

## 🔁 Pattern Connection

This problem uses:
- Divisor checking
- √n optimization

Used in:
- Prime numbers
- Factor problems
- Number theory basics
