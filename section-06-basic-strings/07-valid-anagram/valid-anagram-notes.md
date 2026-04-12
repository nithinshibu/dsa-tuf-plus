# Anagram Strings – Beginner Friendly Explanation

## 🧠 Problem Understanding

We are given two strings:

- s
- t

We need to check:
👉 Are both strings made of the **same characters with same frequency**?

If yes → ✅ Anagram  
If no → ❌ Not anagram

---

## 💡 Simple Example

```
s = "listen"
t = "silent"
```

Both contain:

- l, i, s, t, e, n (same count)

👉 So they are **anagrams**

---

## ❌ Non-Anagram Example

```
s = "hello"
t = "world"
```

Different characters → ❌ Not anagram

---

## 🔥 Core Idea (Thinking Process)

Instead of sorting (which is slower), we use a **counting technique**.

### Key Thought:

👉 If two strings are anagrams, then:

- Every character count in s should match t

---

## ⚙️ Step-by-Step Approach

### Step 1: Length Check

```
if (s.Length != t.Length) return false;
```

👉 If lengths differ → impossible to be anagram

---

### Step 2: Create Count Array

```
int[] count = new int[26];
```

👉 Why 26?
Because only lowercase letters (a–z)

👉 Index mapping:

- 'a' → 0
- 'b' → 1
- ...
- 'z' → 25

---

### Step 3: Count Characters in First String

```
foreach (char c in s)
{
    count[c - 'a']++;
}
```

👉 Example:
s = "abc"

count becomes:
[1, 1, 1, 0, 0, ...]

## 🔤 Character to Index Mapping

👉 count[c - 'a']++;

| Character | Calculation    | Index |
| --------- | -------------- | ----- |
| 'a'       | 'a' - 'a' = 0  | 0     |
| 'b'       | 'b' - 'a' = 1  | 1     |
| 'c'       | 'c' - 'a' = 2  | 2     |
| ...       | ...            | ...   |
| 'z'       | 'z' - 'a' = 25 | 25    |

👉 So:

- 'a' goes to index 0
- 'b' goes to index 1
- 'c' goes to index 2
- ...
- 'z' goes to index 25

---

### Step 4: Decrease Using Second String

```
foreach (char c in t)
{
    count[c - 'a']--;
}
```

👉 If perfectly matched → all values become 0

---

### Step 5: Final Check

```
foreach (int i in count)
{
    if (i != 0) return false;
}
```

👉 If any value ≠ 0 → mismatch

---

## 🧪 Dry Run Example

```
s = "integer"
t = "tegerni"
```

### After Step 3 (count s):

i → 1  
n → 1  
t → 1  
e → 2  
g → 1  
r → 1

### After Step 4 (subtract t):

All values → 0 ✅

👉 So result = true

---

## 🚀 Why This is Optimized?

Instead of sorting (O(n log n)), we:

- Traverse once for s
- Traverse once for t
- Traverse fixed array (26)

👉 Much faster!

---

## ⏱️ Time Complexity

### Breakdown:

1. Loop over s → O(n)
2. Loop over t → O(n)
3. Loop over count array (size 26) → O(1)

### Final:

👉 **O(n)**

---

## 📦 Space Complexity

We use:

```
int[] count = new int[26];
```

👉 Size is constant (26)

👉 **O(1)** (Constant space)

---

## 🧠 Key Learning for Revision

- Always check **length first**
- Use **frequency counting instead of sorting**
- If all counts cancel → anagram
- Fixed array → constant space → efficient

---

## 🔁 Mental Shortcut

👉 Think like this:

"Increase for s, decrease for t — if everything balances → anagram"

---

## 📌 When to Use This Pattern?

Use this technique when:

- Comparing strings
- Counting frequencies
- Working with alphabets (fixed size)

---

## 🏁 Final Code Summary

```
int[] count = new int[26];

foreach (char c in s)
    count[c - 'a']++;

foreach (char c in t)
    count[c - 'a']--;

foreach (int i in count)
    if (i != 0) return false;

return true;
```

---

## 🎯 Final Takeaway

This is a **classic DSA pattern**:
👉 "Use counting instead of sorting for better performance"

---
