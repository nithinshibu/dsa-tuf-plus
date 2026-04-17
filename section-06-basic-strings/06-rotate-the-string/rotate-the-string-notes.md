# Rotate String (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given two strings `s` and `goal`, check if `goal` can be obtained by **rotating** `s`.

👉 Rotation = move first character to end

---

## 📌 Examples

- Input: `s = "abcde"`, `goal = "cdeab"` → Output: `true`  
- Input: `s = "abcde"`, `goal = "abced"` → Output: `false`  

---

## 💡 Intuition (Very Simple Thinking)

👉 Instead of actually rotating multiple times (slow), use a trick:

👉 If `goal` is a rotation of `s`, then:

```
goal must be a substring of (s + s)
```

---

## 🔁 Why does this work?

Take:
```
s = "abcde"
```

Double it:
```
s + s = "abcdeabcde"
```

Now all rotations exist inside this:

- "bcdea" ✅  
- "cdeab" ✅  
- "deabc" ✅  

👉 So just check:
```
(s + s).Contains(goal)
```

---

## ⚙️ Step-by-Step Execution

### Input:
```
s = "abcde"
goal = "cdeab"
```

---

### Step 1: Length check

```
5 == 5 → continue
```

---

### Step 2: Double string

```
doubled = "abcdeabcde"
```

---

### Step 3: Check substring

```
"cdeab" exists in doubled → true
```

---

## 🧾 Final Code (C#)

```csharp
public bool rotateString(string s, string goal)
{
    if (s.Length != goal.Length)
    {
        return false;
    }

    string doubledS = s + s;

    return doubledS.Contains(goal);
}
```

---

## 🎯 Key Insight

👉 Rotation = substring of (s + s)

👉 No need to simulate shifts

---

# 🧮 Time Complexity (VERY DETAILED)

## Step 1: Concatenation

```
s + s → O(n)
```

---

## Step 2: Contains()

👉 Worst case:
```
O(n * n) = O(n²)
```

---

## Final Time Complexity

```
O(n²)
```

---

## 💾 Space Complexity (VERY DETAILED)

We create:
```
doubledS = s + s → size = 2n
```

So:
```
Space Complexity = O(n)
```

---

## ⚠️ Edge Cases

1. Different lengths → false  
2. Empty strings → true  
3. Same strings → true  

---

## ⚠️ Common Mistakes

1. ❌ Trying all rotations manually  
2. ❌ Forgetting length check  
3. ❌ Not understanding substring trick  

---

## 🔄 How to Think During Revision

When you see:
👉 "rotation"

Think:

1. Double string  
2. Check substring  

---

## 🧩 Summary (Quick Recall)

- Length must match  
- Create s + s  
- Check Contains  

---

## 🚀 Final Mental Model

👉 “All rotations live inside s + s”

---

## 🔁 Pattern Connection

This problem uses:
- String trick  
- Substring search  
- Optimization idea  
