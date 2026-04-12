# Armstrong Number (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given an integer `n`, check whether it is an **Armstrong number**.

👉 An Armstrong number is:
A number equal to the sum of its digits raised to the power of the number of digits.

---

## 📌 Examples

- Input: `153` → Output: `true`
- Input: `123` → Output: `false`

---

## 💡 Intuition (Very Simple Thinking)

👉 Steps:
1. Count number of digits → `k`
2. Take each digit
3. Raise it to power `k`
4. Add all results
5. Compare with original number

---

## 🔁 Example Walkthrough

### Input:
```
n = 153
```

### Step 1: Count digits
```
digits = 3
```

### Step 2: Process digits

- 3³ = 27
- 5³ = 125
- 1³ = 1

### Step 3: Sum
```
27 + 125 + 1 = 153
```

### Step 4: Compare
```
153 == 153 → true ✅
```

---

## ⚙️ Code Breakdown

### Count Digits Logic

```
digits = floor(log10(n)) + 1
```

👉 Example:
- log10(153) ≈ 2 → digits = 3

---

### Main Logic

- Extract digit → `% 10`
- Raise power → `Math.Pow(digit, count)`
- Add to sum
- Remove digit → `/ 10`

---

## 🧾 Final Code (C#)

```csharp
using System;

public class Solution
{
    public int countDigit(int n)
    {
        if (n == 0) return 1;
        int count = (int)Math.Floor(Math.Log10(n)) + 1;
        return count;
    }

    public bool isArmstrong(int n)
    {
        int count = this.countDigit(n);

        long sum = 0;
        int copy = n;

        int tempN = n;
        while (tempN > 0)
        {
            int lastDigit = tempN % 10;

            sum += (long)Math.Pow(lastDigit, count);

            tempN /= 10;
        }

        return sum == copy;
    }
}
```

---

## 🎯 Key Insight

👉 This combines:
- Digit extraction
- Power calculation
- Sum accumulation
- Comparison

---

## 🧮 Time Complexity (Detailed)

Let number of digits = `d`

- Loop runs `d` times
- Each step includes power calculation

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
- sum
- count
- temp variables

```
Space Complexity = O(1)
```

---

## ⚠️ Edge Cases

1. n = 0 → Armstrong (0^1 = 0)
2. Large n → possible overflow (handled using long)
3. Negative numbers → usually not considered

---

## ⚠️ Common Mistakes

1. ❌ Wrong digit count
2. ❌ Not using power correctly
3. ❌ Modifying original number
4. ❌ Overflow (not using long)

---

## 🔄 How to Think During Revision

When you see this problem:

1. "Find number of digits"
2. "Raise each digit to that power"
3. "Sum them"
4. "Compare with original"

---

## 🧩 Summary (Quick Recall)

- Count digits
- Extract digits
- Power + sum
- Compare

---

## 🚀 Final Mental Model

👉 “Power + Sum + Compare”

---

## 🔁 Pattern Connection

This problem combines:
- Digit extraction
- Mathematical transformation
- Accumulation

Used in:
- Armstrong numbers
- Digit power problems
