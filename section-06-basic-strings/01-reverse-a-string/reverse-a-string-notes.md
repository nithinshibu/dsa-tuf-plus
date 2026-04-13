# Reverse String (Two Pointers) – Detailed Revision Notes

## 🧠 Problem Statement
Given a character array `s`, reverse the array **in-place**.

👉 In-place means:
- Do NOT use extra memory
- Modify the same array

---

## 📌 Examples

- Input: `['h','e','l','l','o']`  
  Output: `['o','l','l','e','h']`

---

## 💡 Intuition (Very Simple Thinking)

👉 Think like this:

“Swap first and last → move inward → repeat”

---

# 🔁 Approach 1: Using Temporary Variable (Classic Way)

## 🧾 Code

```csharp
char tmp = s[left];
s[left] = s[right];
s[right] = tmp;
```

---

## ⚙️ Step-by-Step Example

### Input:
```
['h','e','l','l','o']
```

### Step 1:
- left = 0 ('h')
- right = 4 ('o')

Swap:
```
['o','e','l','l','h']
```

---

### Step 2:
- left = 1 ('e')
- right = 3 ('l')

Swap:
```
['o','l','l','e','h']
```

---

### Stop:
```
left == right
```

---

## 🎯 Why we use temp variable?

👉 Because if you do:
```
s[left] = s[right]
```
You lose original value of `s[left]`

So temp stores it safely.

---

# 🔁 Approach 2: Tuple Swap (Modern C#)

## 🧾 Code

```csharp
(s[left], s[right]) = (s[right], s[left]);
```

---

## 💡 What is this?

👉 This is called **tuple assignment**

👉 It swaps values in ONE line

---

## 🧠 How it Works Internally

This:
```
(s[left], s[right]) = (s[right], s[left]);
```

👉 is equivalent to:

```
tmp = s[left]
s[left] = s[right]
s[right] = tmp
```

---

## ⚙️ Step-by-Step Example

Before:
```
s[left] = 'h'
s[right] = 'o'
```

After:
```
s[left] = 'o'
s[right] = 'h'
```

---

## 🎯 Why this is useful

👉 Cleaner code  
👉 No temp variable  
👉 Same logic internally  

---

## ⚠️ Important Note

👉 Even though it looks like magic:

It is simply:
- Right goes to left
- Left goes to right

---

# 🧮 Time Complexity

```
O(n)
```

👉 Each element is visited once

---

# 💾 Space Complexity

```
O(1)
```

👉 No extra memory used

---

# ⚠️ Common Mistakes

1. ❌ Forgetting pointer movement  
2. ❌ Incorrect swap  
3. ❌ Using extra array  

---

# 🔄 How to Think During Revision

When you see:
👉 Reverse string / array

Think:

1. Two pointers  
2. Swap  
3. Move inward  

---

# 🧩 Summary (Quick Recall)

- left = 0  
- right = n-1  
- Swap  
- Move inward  

---

# 🚀 Final Mental Model

👉 “Mirror swap from both ends”

---

# 🔁 Pattern Connection

This is a **Two Pointer Pattern**

Used in:
- Palindrome check  
- Reverse array/string  
- Two sum (sorted)  
- Sliding window  

---

# ⚡ Final Takeaway

| Approach | Notes |
|--------|------|
| Temp variable | Easy to understand |
| Tuple swap | Cleaner, modern |

---

👉 Both are SAME logic, only syntax differs.
