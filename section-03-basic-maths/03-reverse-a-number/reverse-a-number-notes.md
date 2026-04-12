# Reverse Number (DSA) – Detailed Revision Notes

## 🧠 Problem Statement

Given an integer `n`, reverse its digits.

### Example:

- Input: `1234`
- Output: `4321`

---

## 💡 Intuition (Very Simple Thinking)

Think of the number as a sequence of digits.

👉 Example: `1234`

We want to **take digits from the end and rebuild the number from scratch**.

### Step-by-step idea:

- Take last digit → `4`
- Then `3`
- Then `2`
- Then `1`

Now rebuild:

- Start with `0`
- Add `4` → `4`
- Add `3` → `43`
- Add `2` → `432`
- Add `1` → `4321`

---

## 🔁 How Do We Get Last Digit?

We use:

```
n % 10
```

👉 Example:

- `1234 % 10 = 4`
- `123 % 10 = 3`

---

## 🔁 How Do We Remove Last Digit?

We use:

```
n / 10
```

👉 Example:

- `1234 / 10 = 123`
- `123 / 10 = 12`

---

## ⚙️ Step-by-Step Execution

Let’s trace:

### Input:

```
n = 1234
```

### Iteration 1:

- lastDigit = 1234 % 10 = 4
- revNum = 0 \* 10 + 4 = 4
- n = 1234 / 10 = 123

### Iteration 2:

- lastDigit = 3
- revNum = 4 \* 10 + 3 = 43
- n = 12

### Iteration 3:

- lastDigit = 2
- revNum = 43 \* 10 + 2 = 432
- n = 1

### Iteration 4:

- lastDigit = 1
- revNum = 432 \* 10 + 1 = 4321
- n = 0 → stop

---

## 🧾 Final Code (C#)

```csharp
using System;

public class Solution
{
    public int ReverseNumber(int n)
    {
        int revNum = 0;

        while (n > 0)
        {
            int lastDigit = n % 10;
            revNum = (revNum * 10) + lastDigit;
            n = n / 10;
        }

        return revNum;
    }
}
```

---

## 🎯 Key Insight (IMPORTANT FOR INTERVIEWS)

👉 The trick is:

- Extract last digit
- Shift previous result left (×10)
- Add new digit

---

## 🧮 Time Complexity (Detailed)

Let number of digits = `d`

### Loop runs:

- Once per digit → `d` times

### Inside loop:

- Constant operations (`%`, `/`, `*`, `+`)

### Final:

```
Time Complexity = O(d)
```

👉 Since `d ≈ log₁₀(n)`:

```
Time Complexity = O(log n)
```

---

## 💾 Space Complexity (Detailed)

We are only using:

- `revNum`
- `lastDigit`
- `n`

No extra data structures.

```
Space Complexity = O(1)
```

---

## ⚠️ Common Mistakes

1. ❌ Forgetting to multiply by 10
2. ❌ Infinite loop (not reducing `n`)
3. ❌ Not understanding digit extraction

---

## 🔄 How to Think During Revision

When you see this problem, think:

1. "I need last digit → use % 10"
2. "I need to build new number → multiply by 10"
3. "I need to remove digit → divide by 10"
4. "Loop until number becomes 0"

---

## 🧩 Summary (Quick Recall)

- Extract → `% 10`
- Remove → `/ 10`
- Build → `revNum * 10 + digit`
- Loop → until `n == 0`

---

## 🚀 Final Mental Model

👉 “Take from right, build from left”

---

This pattern is VERY common in DSA.
You will reuse it in:

- Palindrome check
- Digit sum problems
- Armstrong numbers
