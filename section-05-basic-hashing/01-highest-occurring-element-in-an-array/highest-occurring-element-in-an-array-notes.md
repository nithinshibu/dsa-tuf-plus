# Most Frequent Element in Array (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given an array `nums`, find the element that appears **most frequently**.

👉 If multiple elements have the same highest frequency, return the **smallest one**.

---

## 📌 Examples

- Input: `[1, 2, 2, 3, 3]` → Output: `2`  
- Input: `[4, 4, 1, 1]` → Output: `1` (tie → smaller wins)

---

## 💡 Intuition (Very Simple Thinking)

👉 We need to:
1. Count how many times each number appears  
2. Find the number with highest count  
3. If tie → pick smaller number  

---

## 🔁 Core Idea

👉 Use **Hashing (Dictionary)**

- Key → number  
- Value → frequency  

---

## ⚙️ Step-by-Step Execution

### Input:
```
nums = [1, 2, 2, 3, 3]
```

---

### Step 1: Build frequency map

```
1 → 1
2 → 2
3 → 2
```

---

### Step 2: Find max frequency

- maxFreq = 2  
- Candidates = 2, 3  

👉 Choose smaller → 2  

---

## 🧾 Final Code (C#)

```csharp
public int mostFrequentElement(int[] nums)
{
    int n = nums.Length;

    int maxFreq = 0;
    int maxEle = 0;

    Dictionary<int, int> mpp = new Dictionary<int, int>();

    for (int i = 0; i < n; i++)
    {
        if (mpp.ContainsKey(nums[i]))
        {
            mpp[nums[i]]++;
        }
        else
        {
            mpp[nums[i]] = 1;
        }
    }

    foreach (var entry in mpp)
    {
        int ele = entry.Key;
        int freq = entry.Value;

        if (freq > maxFreq)
        {
            maxFreq = freq;
            maxEle = ele;
        }
        else if (freq == maxFreq)
        {
            maxEle = Math.Min(maxEle, ele);
        }
    }

    return maxEle;
}
```

---

## 🎯 Key Insight

👉 This is a **Frequency Counting Pattern**

- Count → Compare → Decide  

---

## 🧮 Time Complexity (Detailed)

### Step 1: Build map
```
O(n)
```

### Step 2: Traverse map
```
O(n)
```

👉 Total:
```
Time Complexity = O(n)
```

---

## 💾 Space Complexity (Detailed)

Dictionary stores up to `n` elements:

```
Space Complexity = O(n)
```

---

## ⚠️ Edge Cases

1. All elements same → return that  
2. All unique → return smallest element  
3. Multiple max → tie-breaking needed  

---

## ⚠️ Common Mistakes

1. ❌ Forgetting tie-breaking  
2. ❌ Not updating frequency correctly  
3. ❌ Using nested loops (O(n²))  

---

## 🔄 How to Think During Revision

When you see this problem:

1. "This is frequency counting"
2. "Use hashmap"
3. "Track max and tie"

---

## 🧩 Summary (Quick Recall)

- Count frequencies  
- Track max  
- Handle tie  

---

## 🚀 Final Mental Model

👉 “Count → Compare → Pick best”

---

## 🔁 Pattern Connection

This problem uses:
- Hashing (VERY IMPORTANT)
- Frequency counting
- Optimization from O(n²) → O(n)

Used in:
- Majority element  
- Top K frequent elements  
- Anagrams  
