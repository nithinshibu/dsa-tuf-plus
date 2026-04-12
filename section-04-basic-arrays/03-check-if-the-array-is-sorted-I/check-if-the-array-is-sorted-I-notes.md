# Check if Array is Sorted (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given an array `arr` of size `n`, check whether the array is **sorted in non-decreasing order**.

👉 Non-decreasing means:
Each element is **less than or equal to** the next element.

---

## 📌 Examples

- Input: `[1, 2, 3, 4, 5]` → Output: `true`
- Input: `[1, 2, 2, 3]` → Output: `true`
- Input: `[1, 3, 2, 4]` → Output: `false`

---

## 💡 Intuition (Very Simple Thinking)

👉 A sorted array means:
Every element should be **≤ next element**

So we just:
- Compare neighbors
- If any violation → not sorted

---

## 🔁 Core Idea

- Loop through array
- Compare `arr[i]` and `arr[i+1]`
- If `arr[i] > arr[i+1]` → return false

---

## ⚙️ Step-by-Step Execution

### Input:
```
arr = [1, 2, 3, 4]
```

### Iteration:

- 1 ≤ 2 ✅  
- 2 ≤ 3 ✅  
- 3 ≤ 4 ✅  

No violations → sorted ✅

---

### Input:
```
arr = [1, 3, 2, 4]
```

### Iteration:

- 1 ≤ 3 ✅  
- 3 > 2 ❌ → NOT sorted  

---

## 🧾 Final Code (C#)

```csharp
public bool arraySortedOrNot(int[] arr, int n)
{
    for (int i = 0; i < n - 1; i++)
    {
        if (arr[i] > arr[i + 1])
        {
            return false;
        }
    }
    return true;
}
```

---

## 🎯 Key Insight

👉 Only need to check **adjacent pairs**, not all pairs

---

## 🧮 Time Complexity (Detailed)

Loop runs `n-1` times:
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

1. Empty array → sorted  
2. Single element → sorted  
3. All equal elements → sorted  

---

## ⚠️ Common Mistakes

1. ❌ Loop till `n` (out of bounds)  
2. ❌ Using wrong comparison  
3. ❌ Checking all pairs instead of adjacent  

---

## 🔄 How to Think During Revision

When you see this problem:

1. "Check neighbors"
2. "Look for violation"
3. "Return early if found"

---

## 🧩 Summary (Quick Recall)

- Compare adjacent elements  
- If any decreasing pair → false  
- Else → true  

---

## 🚀 Final Mental Model

👉 “Scan neighbors and detect violation”

---

## 🔁 Pattern Connection

This problem uses:
- Linear traversal  
- Adjacent comparison  
- Early exit  

Used in:
- Sorted checks  
- Monotonic array problems  
- Binary search pre-check  
