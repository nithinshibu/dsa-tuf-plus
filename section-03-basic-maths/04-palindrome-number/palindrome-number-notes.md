# Palindrome Number (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given an integer `n`, check if it is a palindrome.

👉 A palindrome is a number that reads the same forward and backward.

### Examples:
- Input: `121` → Output: `true`
- Input: `123` → Output: `false`

---

## 💡 Intuition (Very Simple Thinking)

👉 A palindrome number looks the same when reversed.

So the idea is:
1. Reverse the number
2. Compare it with the original

If both are same → palindrome  
Else → not palindrome

---

## 🔁 Step-by-Step Idea

Take number: `121`

- Reverse it → `121`
- Compare → same → palindrome ✅

Take number: `123`

- Reverse it → `321`
- Compare → not same → not palindrome ❌

---

## ⚙️ Step-by-Step Execution

### Input:
```
n = 121
```

### Initial:
- copy = 121
- revNum = 0

---

### Iteration 1:
- lastDigit = 121 % 10 = 1
- revNum = 0 * 10 + 1 = 1
- n = 12

### Iteration 2:
- lastDigit = 2
- revNum = 1 * 10 + 2 = 12
- n = 1

### Iteration 3:
- lastDigit = 1
- revNum = 12 * 10 + 1 = 121
- n = 0 → stop

---

### Final Check:
```
revNum == copy → 121 == 121 → true
```

---

## 🧾 Final Code (C#)

```csharp
using System;

public class Solution
{
    public bool IsPalindrome(int n)
    {
        int copy = n;
        int revNum = 0;

        while (n > 0)
        {
            int lastDigit = n % 10;
            revNum = (revNum * 10) + lastDigit;
            n = n / 10;
        }

        return revNum == copy;
    }
}
```

---

## 🎯 Key Insight (IMPORTANT)

👉 This problem is just:
- Reverse the number
- Compare with original

---

## 🧮 Time Complexity (Detailed)

Let number of digits = `d`

### Loop runs:
- Once per digit → `d` times

Each step does constant work.

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
- copy
- revNum
- lastDigit

No extra data structures.

```
Space Complexity = O(1)
```

---

## ⚠️ Common Mistakes

1. ❌ Not storing original number (copy)
2. ❌ Modifying original number and comparing wrongly
3. ❌ Forgetting reverse logic

---

## 🔄 How to Think During Revision

When you see this problem:

1. "Palindrome means same forward & backward"
2. "I can reverse the number"
3. "Compare reversed with original"

---

## 🧩 Summary (Quick Recall)

- Reverse number
- Compare with original
- If equal → palindrome

---

## 🚀 Final Mental Model

👉 “Reverse and compare”

---

## 🔁 Pattern Connection

This problem uses:
- Reverse number logic (same as previous problem)

Used in:
- Palindrome numbers
- Palindrome strings
- Digit-based problems
