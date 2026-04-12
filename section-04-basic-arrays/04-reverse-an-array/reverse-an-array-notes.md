# Reverse Array (Two Pointers) – Detailed Revision Notes

## 🧠 Problem Statement
Given an array `arr` of size `n`, reverse the array **in-place**.

👉 In-place means: do it without using extra space.

---

## 📌 Examples

- Input: `[1, 2, 3, 4, 5]`  
  Output: `[5, 4, 3, 2, 1]`

- Input: `[10, 20, 30]`  
  Output: `[30, 20, 10]`

---

## 💡 Intuition (Very Simple Thinking)

👉 Instead of creating a new array, we:
- Swap first and last
- Then move inward

---

## 🔁 Core Idea (Two Pointers)

Use two pointers:
- `p1` → start (0)
- `p2` → end (n-1)

Then:
- Swap arr[p1] and arr[p2]
- Move inward:
  - p1++
  - p2--

Stop when they meet.

---

## ⚙️ Step-by-Step Execution

### Input:
```
arr = [1, 2, 3, 4, 5]
```

### Initial:
- p1 = 0
- p2 = 4

---

### Iteration 1:
- Swap 1 and 5 → [5, 2, 3, 4, 1]
- p1 = 1, p2 = 3

---

### Iteration 2:
- Swap 2 and 4 → [5, 4, 3, 2, 1]
- p1 = 2, p2 = 2 → stop

---

## 🧾 Final Code (C#)

```csharp
public void reverse(int[] arr, int n)
{
    int p1 = 0, p2 = n - 1;

    while (p1 < p2)
    {
        int tmp = arr[p1];
        arr[p1] = arr[p2];
        arr[p2] = tmp;

        p1++;
        p2--;
    }
}
```

---

## 🎯 Key Insight

👉 You don't need extra space  
👉 Just swap from both ends

---

## 🧮 Time Complexity (Detailed)

We process each element once:
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

1. Empty array → no change  
2. Single element → same  
3. Even/odd length → both handled  

---

## ⚠️ Common Mistakes

1. ❌ Forgetting to move pointers  
2. ❌ Using extra array unnecessarily  
3. ❌ Incorrect swap logic  

---

## 🔄 How to Think During Revision

When you see this problem:

1. "Use two pointers"
2. "Swap ends"
3. "Move inward"

---

## 🧩 Summary (Quick Recall)

- p1 = start  
- p2 = end  
- Swap → move inward  

---

## 🚀 Final Mental Model

👉 “Mirror swap from both ends”

---

## 🔁 Pattern Connection

This is a **VERY IMPORTANT pattern**:

👉 Two Pointers

Used in:
- Reverse array/string  
- Palindrome check  
- Two sum (sorted array)  
- Sliding window problems  
