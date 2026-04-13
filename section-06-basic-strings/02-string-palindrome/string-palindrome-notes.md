# String Palindrome Check (Two Pointers) – Detailed Revision Notes

## 🧠 Problem Statement
Given a string `s`, check whether it is a **palindrome**.

👉 A palindrome reads the same **forward and backward**.

---

## 📌 Examples

- Input: `"racecar"` → Output: `true`  
- Input: `"abba"` → Output: `true`  
- Input: `"hello"` → Output: `false`  

---

## 💡 Intuition (Very Simple Thinking)

👉 Compare characters from both ends:
- First with last
- Second with second-last
- Continue moving inward

If all pairs match → palindrome ✅

---

## 🔁 Core Idea (Two Pointers)

- `left` → start (0)
- `right` → end (n-1)

While `left < right`:
- If `s[left] != s[right]` → return false
- Else move inward:
  - `left++`
  - `right--`

---

## ⚙️ Step-by-Step Execution

### Input:
```
s = "racecar"
```

### Iteration 1:
- left = 0 ('r'), right = 6 ('r') → match ✅

### Iteration 2:
- left = 1 ('a'), right = 5 ('a') → match ✅

### Iteration 3:
- left = 2 ('c'), right = 4 ('c') → match ✅

### Stop:
- left == right → middle reached

👉 Result: `true`

---

### Another Example:

```
s = "hello"
```

- left = 0 ('h'), right = 4 ('o') → not equal ❌

👉 Result: `false`

---

## 🧾 Final Code (C#)

```csharp
using System;

public class Solution
{
    public bool palindromeCheck(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
```

---

## 🎯 Key Insight

👉 Only compare **mirror characters**

👉 No need to reverse the string

---

## 🧮 Time Complexity (Detailed)

We check each pair once:
```
Time Complexity = O(n)
```

---

## 💾 Space Complexity (Detailed)

No extra space used:
```
Space Complexity = O(1)
```

---

## ⚠️ Edge Cases

1. Empty string → palindrome  
2. Single character → palindrome  
3. Case sensitivity (e.g., "Aa" → false unless handled)  

---

## ⚠️ Common Mistakes

1. ❌ Using extra string reversal  
2. ❌ Incorrect pointer movement  
3. ❌ Ignoring case/space issues (in advanced problems)  

---

## 🔄 How to Think During Revision

When you see:
👉 “Palindrome”

Think:

1. Two pointers  
2. Compare ends  
3. Move inward  

---

## 🧩 Summary (Quick Recall)

- left = 0  
- right = n-1  
- Compare  
- Move inward  

---

## 🚀 Final Mental Model

👉 “Check mirror characters from both ends”

---

## 🔁 Pattern Connection

This uses:
- Two pointers  
- In-place comparison  

Used in:
- Palindrome string  
- Palindrome number  
- Valid palindrome problems  

---

## ⚡ Final Takeaway

👉 No need to reverse  
👉 Just compare from both ends  

👉 Fast and optimal solution
