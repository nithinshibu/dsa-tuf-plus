# 📘 Count Odd Digits in a Number (Interview-Ready + Revision Guide)

---

## 🧠 Problem Summary

Given a number `n`, count how many **odd digits** are present in it.

### Example:

- Input: `n = 12345`
- Output: `3` (1, 3, 5 are odd)

---

## 💡 Thinking Process (How to Approach This)

### Step 1: Understand the problem

We are not interested in the full number ---\
👉 we only care about **each individual digit**

---

### Step 2: How to access each digit?

We use a common trick in DSA:

- `n % 10` → gives last digit
- `n / 10` → removes last digit

👉 This helps us **iterate through digits**

---

### Step 3: What do we check?

For each digit: - If `digit % 2 != 0` → it's odd

👉 Count such digits

---

## 🚀 Code

```csharp
public int countOddDigit(int n)
{
    int oddDigits = 0;

    while (n > 0)
    {
        int lastDigit = n % 10;

        if (lastDigit % 2 != 0)
        {
            oddDigits = oddDigits + 1;
        }

        n = n / 10;
    }

    return oddDigits;
}
```

---

## 🔍 Dry Run (Step-by-Step)

### Example: n = 472531

Step n lastDigit Odd? Count

---

1 472531 1 ✅ 1
2 47253 3 ✅ 2
3 4725 5 ✅ 3
4 472 2 ❌ 3
5 47 7 ✅ 4
6 4 4 ❌ 4

👉 Final Answer = **4**

---

## ⚠️ Edge Cases

### 1. n = 0

- Loop won't run
- Output = 0 (correct, since 0 is not odd)

---

### 2. Negative numbers (if asked in interview)

👉 Convert to positive:

```csharp
n = Math.Abs(n);
```

---

## 🧠 Time Complexity (Important for Interview)

### O(log₁₀ n)

Why?

- Each iteration removes one digit
- Number of digits in `n` = log₁₀(n)

👉 So loop runs **digit count times**

---

## 🧠 Space Complexity

### O(1)

- No extra memory used
- Only a counter variable

---

## ⚖️ Why This Approach?

Approach Idea Time

---

String conversion Convert number to string O(n) extra space
Mathematical (this) Use % and / ✅ Best

👉 This is the **most optimal and preferred approach**

---

## 🎯 Interview Explanation (How to Say It)

If interviewer asks:

👉 You can say:

"I iterate through each digit using modulo and division.\
For every digit, I check if it is odd using modulo 2.\
If yes, I increment a counter.\
This runs in O(log n) time since we process each digit once, and uses
constant space."

---

## 🔁 Revision Notes (Quick Recall)

- Extract digit → `n % 10`
- Remove digit → `n / 10`
- Odd check → `digit % 2 != 0`
- Loop until → `n > 0`
- Time → O(log n)
- Space → O(1)

---

## 🚨 Common Mistakes

- Forgetting to update `n = n / 10`
- Using `n % 2` instead of `digit % 2`
- Not handling negative numbers (if required)

---

## 🧭 Recognition Pattern

Use this pattern when: - Problem involves **digits of a number** - You
need to: - Count digits - Sum digits - Check properties of digits

👉 This is a **core DSA pattern**

---

## 🏁 Final Takeaway

👉 Whenever you see: "Process digits of a number"

Think:

    while (n > 0)
    {
        digit = n % 10;
        n = n / 10;
    }

---
