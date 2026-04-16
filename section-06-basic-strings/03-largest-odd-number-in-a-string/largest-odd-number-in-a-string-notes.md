# Largest Odd Number as Substring (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given a numeric string `s`, return the **largest odd-number substring**.

👉 Substring must be **prefix-based up to some index** (i.e., from start to some position).

👉 If no odd number exists → return empty string `""`

---

## 📌 Examples

- Input: `"52"` → Output: `"5"`  
- Input: `"4206"` → Output: `""`  
- Input: `"35427"` → Output: `"35427"`  

---

## 💡 Intuition (Very Simple Thinking)

👉 Key observation:

> An odd number always ends with an **odd digit** (1, 3, 5, 7, 9)

So:
1. Find the **rightmost odd digit**
2. Take substring from start → that index

---

## 🔁 Core Idea

- Traverse from **right → left**
- Find first odd digit
- Return substring from start → that position

---

## ⚙️ Step-by-Step Execution

### Input:
```
s = "35427"
```

### Step 1: Find last odd digit

Check from right:
- '7' → odd ✅

So:
```
last_odd_index = 4
```

---

### Step 2: Remove leading zeros (if any)

(Not needed here)

---

### Step 3: Take substring

```
s[0 → 4] = "35427"
```

---

### Example 2:

```
s = "4206"
```

Check:
- 6 → even  
- 0 → even  
- 2 → even  
- 4 → even  

👉 No odd digit → return ""

---

## 🧾 Final Code (C#)

```csharp
public string LargeOddNum(string s)
{
    int last_odd_index = -1;

    for (int i = s.Length - 1; i >= 0; i--)
    {
        if ((s[i] - '0') % 2 == 1)
        {
            last_odd_index = i;
            break;
        }
    }

    if (last_odd_index == -1)
    {
        return "";
    }

    int start_index = 0;
    while (start_index <= last_odd_index && s[start_index] == '0')
    {
        start_index++;
    }

    return s.Substring(start_index, (last_odd_index + 1) - start_index);
}
```

---

## 🎯 Key Insight

👉 Odd number = last digit must be odd  

👉 So we only care about:
- Last odd position

---

## 🧮 Time Complexity (Detailed)

- Traversal → O(n)  
- Leading zero removal → O(n)

```
Time Complexity = O(n)
```

---

## 💾 Space Complexity (Detailed)

- No extra space used

```
Space Complexity = O(1)
```

---

## ⚠️ Edge Cases

1. No odd digits → return ""  
2. Leading zeros → remove them  
3. Entire string odd → return full string  

---

## ⚠️ Common Mistakes

1. ❌ Checking all substrings (O(n²))  
2. ❌ Not understanding odd rule  
3. ❌ Forgetting leading zeros  

---

## 🔄 How to Think During Revision

When you see:

👉 "Largest odd number"

Think:

1. Odd → last digit matters  
2. Scan from right  
3. Cut substring  

---

## 🧩 Summary (Quick Recall)

- Scan from right  
- Find odd digit  
- Return prefix  

---

## 🚀 Final Mental Model

👉 “Find last odd digit → return everything before it”

---

## 🔁 Pattern Connection

This problem uses:
- String traversal  
- Greedy thinking  
- Substring extraction  

Used in:
- String manipulation  
- Greedy problems  
