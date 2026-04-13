# Sum of Highest and Lowest Frequency (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given an array `nums`, find:

👉 (Highest frequency + Lowest frequency)

Where:
- Frequency = how many times an element appears

---

## 📌 Examples

- Input: `[1, 2, 2, 3, 3, 3]`  
  Frequencies:
  - 1 → 1
  - 2 → 2
  - 3 → 3  

  Output:
  ```
  maxFreq = 3
  minFreq = 1
  sum = 3 + 1 = 4
  ```

---

## 💡 Intuition (Very Simple Thinking)

👉 We need to:
1. Count frequency of each number  
2. Find:
   - maximum frequency  
   - minimum frequency  
3. Add them  

---

## 🔁 Core Idea

👉 Use **HashMap (Dictionary)**

- Step 1 → Count frequency  
- Step 2 → Traverse frequencies  
- Step 3 → Track max & min  

---

## ⚙️ Step-by-Step Execution

### Input:
```
nums = [1, 2, 2, 3, 3, 3]
```

---

### Step 1: Build frequency map

```
1 → 1
2 → 2
3 → 3
```

---

### Step 2: Find max & min

- maxFreq = 3  
- minFreq = 1  

---

### Step 3: Result

```
3 + 1 = 4
```

---

## 🧾 Final Code (C#)

```csharp
public int SumHighestAndLowestFrequency(int[] nums)
{
    int maxFreq = 0;
    int minFreq = nums.Length;

    Dictionary<int, int> map = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (map.ContainsKey(nums[i]))
            map[nums[i]]++;
        else
            map[nums[i]] = 1;
    }

    foreach (int freq in map.Values)
    {
        maxFreq = Math.Max(maxFreq, freq);
        minFreq = Math.Min(minFreq, freq);
    }

    return maxFreq + minFreq;
}
```

---

## 🎯 Key Insight

👉 This is:
- Frequency counting  
- + Min/Max tracking  

---

## 🧮 Time Complexity (Detailed)

### Build map:
```
O(n)
```

### Traverse frequencies:
```
O(n)
```

👉 Total:
```
Time Complexity = O(n)
```

---

## 💾 Space Complexity (Detailed)

- Dictionary stores elements:

```
Space Complexity = O(n)
```

---

## ⚠️ Edge Cases

1. All elements same  
   → max = min → sum = 2 × freq  

2. All elements unique  
   → all freq = 1 → sum = 2  

---

## ⚠️ Common Mistakes

1. ❌ Initializing minFreq incorrectly  
2. ❌ Not iterating over map values  
3. ❌ Using nested loops  

---

## 🔄 How to Think During Revision

When you see this problem:

1. "Count frequency"
2. "Find max and min"
3. "Add them"

---

## 🧩 Summary (Quick Recall)

- Count frequencies  
- Track max & min  
- Return sum  

---

## 🚀 Final Mental Model

👉 “Count → Find extremes → Combine”

---

## 🔁 Pattern Connection

This problem uses:
- Hashing  
- Frequency counting  
- Min/Max tracking  

Used in:
- Frequency-based problems  
- Range queries  
