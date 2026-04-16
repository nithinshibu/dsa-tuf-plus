# Longest Common Prefix (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given an array of strings `strs`, find the **longest common prefix** among all strings.

👉 If there is no common prefix, return `""`

---

## 📌 Examples

- Input: `["flower","flow","flight"]` → Output: `"fl"`  
- Input: `["dog","racecar","car"]` → Output: `""`  

---

## 💡 Intuition (Very Simple Thinking)

👉 Instead of comparing ALL strings pairwise (complex), use a smart trick:

> Sort the array → compare only **first and last string**

Why?

👉 After sorting:
- First string → smallest (lexicographically)
- Last string → largest

👉 The common prefix of ALL strings must be common between these two

---

## 🔁 Core Idea

1. Sort the array  
2. Take:
   - first string  
   - last string  
3. Compare character by character  
4. Build prefix until mismatch  

---

## ⚙️ Step-by-Step Execution

### Input:
```
["flower","flow","flight"]
```

### Step 1: Sort

```
["flight","flow","flower"]
```

---

### Step 2: Pick first & last

```
first = "flight"
last  = "flower"
```

---

### Step 3: Compare

- f == f ✅ → prefix = "f"  
- l == l ✅ → prefix = "fl"  
- i != o ❌ → stop  

---

### Final Answer:
```
"fl"
```

---

## 🧾 Final Code (C#)

```csharp
public string LongestCommonPrefix(string[] strs)
{
    if (strs.Length == 0) return "";

    Array.Sort(strs);

    string first = strs[0];
    string last = strs[strs.Length - 1];

    string commonPrefix = "";

    for (int i = 0; i < Math.Min(first.Length, last.Length); i++)
    {
        if (first[i] != last[i])
        {
            return commonPrefix;
        }
        commonPrefix += first[i];
    }

    return commonPrefix;
}
```

---

## 🎯 Key Insight

👉 After sorting:
Only **first & last strings matter**

---

## 🧮 Time Complexity (Detailed)

### Sorting:
- N strings
- Each comparison = O(M)

```
Sorting = O(N log N * M)
```

### Comparing first & last:
```
O(M)
```

👉 Final:
```
O(N * M * log N)
```

---

## 💾 Space Complexity (Detailed)

- Only prefix string stored

```
Space Complexity = O(M)
```

---

## ⚠️ Edge Cases

1. Empty array → return ""  
2. One string → return that string  
3. No common prefix → return ""  

---

## ⚠️ Common Mistakes

1. ❌ Comparing all strings (slow)  
2. ❌ Not sorting  
3. ❌ Incorrect prefix building  

---

## 🔄 How to Think During Revision

When you see:
👉 “Common prefix”

Think:

1. Sort array  
2. Compare first & last  
3. Build prefix  

---

## 🧩 Summary (Quick Recall)

- Sort  
- Compare first & last  
- Build prefix  

---

## 🚀 Final Mental Model

👉 “Sort → Compare extremes → Extract prefix”

---

## 🔁 Pattern Connection

This problem uses:
- Sorting  
- String comparison  
- Greedy extraction  

Used in:
- Prefix problems  
- String grouping  
