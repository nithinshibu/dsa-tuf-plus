# Isomorphic Strings (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given two strings `s` and `t`, check if they are **isomorphic**.

👉 Two strings are isomorphic if:
- Characters in `s` can be replaced to get `t`
- Mapping must be consistent (same character → same mapping)
- No two characters map to same character

---

## 📌 Examples

- Input: `s = "egg", t = "add"` → Output: `true`
- Input: `s = "foo", t = "bar"` → Output: `false`
- Input: `s = "paper", t = "title"` → Output: `true`

---

## 💡 Intuition (Very Simple Thinking)

👉 We need to track:
- When did we last see a character?

👉 If pattern of occurrences is same → strings are isomorphic

---

## 🔁 Core Idea

Use two arrays:
- m1 → tracks positions for s
- m2 → tracks positions for t

👉 Compare last seen positions

---

## ⚙️ Step-by-Step Execution

### Input:
```
s = "egg"
t = "add"
```

---

### Iteration 1:
- s[0] = 'e', t[0] = 'a'
- m1[e] = 0, m2[a] = 0 → match ✅

Update:
```
m1[e] = 1
m2[a] = 1
```

---

### Iteration 2:
- s[1] = 'g', t[1] = 'd'
- m1[g] = 0, m2[d] = 0 → match ✅

Update:
```
m1[g] = 2
m2[d] = 2
```

---

### Iteration 3:
- s[2] = 'g', t[2] = 'd'
- m1[g] = 2, m2[d] = 2 → match ✅

---

👉 Result: true

---

## 🧾 Final Code (C#)

```csharp
public bool isomorphicString(string s, string t)
{
    int[] m1 = new int[256];
    int[] m2 = new int[256];

    int n = s.Length;

    for (int i = 0; i < n; ++i)
    {
        if (m1[s[i]] != m2[t[i]])
        {
            return false;
        }

        m1[s[i]] = i + 1;
        m2[t[i]] = i + 1;
    }

    return true;
}
```

---

# 🧮 Time Complexity (VERY DETAILED)

## Step 1: Loop

```
for (int i = 0; i < n; i++)
```

👉 Runs `n` times

---

## Step 2: Inside Loop

Each iteration does:
- Array access → O(1)
- Comparison → O(1)
- Assignment → O(1)

👉 All operations are constant time

---

## Final Time Complexity

```
O(n)
```

👉 Linear time

---

## 🧠 Intuition for Time Complexity

👉 If:
- Input size doubles → operations double

So:
```
T(n) ∝ n
```

---

# 💾 Space Complexity (VERY DETAILED)

## Arrays Used

```
int[] m1 = new int[256];
int[] m2 = new int[256];
```

👉 Total size:
```
256 + 256 = 512 (constant)
```

---

## Important Observation

👉 This size does NOT depend on input `n`

Even if:
- n = 10 → arrays still 256
- n = 1,000,000 → arrays still 256

---

## Final Space Complexity

```
O(1)
```

👉 Constant space

---

## 🧠 Why O(1)?

Because:
- Memory used is fixed
- Not growing with input

---

## ⚠️ Note (Important for Interviews)

Sometimes written as:
```
O(k)
```

Where:
- k = character set size (256 for ASCII)

But since k is fixed → treated as O(1)

---

# ⚠️ Common Mistakes

1. ❌ Using dictionary unnecessarily  
2. ❌ Not handling mapping consistency  
3. ❌ Forgetting bidirectional check  

---

# 🔄 How to Think During Revision

When you see:
👉 "pattern matching between strings"

Think:

1. Track positions  
2. Compare patterns  
3. Use arrays for speed  

---

# 🧩 Summary (Quick Recall)

- Use 2 arrays  
- Compare last seen positions  
- Update positions  

---

# 🚀 Final Mental Model

👉 “Same pattern → same last seen positions”

---

# 🔁 Pattern Connection

This problem uses:
- Hashing (array-based)  
- Pattern matching  
- Constant space optimization  

Used in:
- String mapping problems  
- Pattern matching  
