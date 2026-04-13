# Second Most Frequent Element (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given an array `nums`, find the **second most frequent element**.

👉 If multiple elements have same frequency:
- Choose **smaller element**  
👉 If second most frequent does not exist → return `-1`

---

## 📌 Examples

- Input: `[1, 2, 2, 3, 3, 3]`  
  Output: `2`  
  (3 → freq 3, 2 → freq 2)

- Input: `[4, 4, 1, 1]`  
  Output: `-1`  
  (both have same freq → no second highest)

---

## 💡 Intuition (Very Simple Thinking)

👉 We already solved:
✔ Most Frequent Element  

Now we extend it:

👉 Instead of tracking only:
- max frequency  

We track:
- max frequency  
- second max frequency  

---

## 🔁 Core Idea

1. Count frequency using HashMap  
2. Track:
   - highest frequency  
   - second highest frequency  
3. Handle tie cases  

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

### Step 2: Traverse map

- Start:
```
maxFreq = -1
secFreq = -1
```

---

### Process 1:
- ele = 1, freq = 1  
→ becomes max  

---

### Process 2:
- ele = 2, freq = 2  
→ new max  
→ old max becomes second  

---

### Process 3:
- ele = 3, freq = 3  
→ new max  
→ old max becomes second  

---

### Final:
```
max → 3
second → 2
```

---

## 🧾 Final Code (C#)

```csharp
public int SecondMostFrequentElement(int[] nums)
{
    int maxFreq = -1, maxElement = -1;
    int secHighestFreq = -1, secHighestElement = -1;

    Dictionary<int, int> map = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (map.ContainsKey(nums[i]))
            map[nums[i]]++;
        else
            map[nums[i]] = 1;
    }

    foreach (var entry in map)
    {
        int freq = entry.Value;
        int ele = entry.Key;

        if (freq > maxFreq)
        {
            secHighestFreq = maxFreq;
            secHighestElement = maxElement;

            maxFreq = freq;
            maxElement = ele;
        }
        else if (freq == maxFreq)
        {
            maxElement = Math.Min(maxElement, ele);
        }
        else if (freq > secHighestFreq)
        {
            secHighestFreq = freq;
            secHighestElement = ele;
        }
        else if (freq == secHighestFreq)
        {
            secHighestElement = Math.Min(secHighestElement, ele);
        }
    }

    return secHighestElement;
}
```

---

## 🎯 Key Insight

👉 Track TWO things:
- max  
- second max  

👉 Update carefully when new max appears

---

## 🧮 Time Complexity (Detailed)

- Build map → O(n)  
- Traverse map → O(n)  

```
Time Complexity = O(n)
```

---

## 💾 Space Complexity (Detailed)

- HashMap stores elements  

```
Space Complexity = O(n)
```

---

## ⚠️ Edge Cases

1. All elements same → no second → return -1  
2. Only one unique element → return -1  
3. Tie cases → choose smaller  

---

## ⚠️ Common Mistakes

1. ❌ Not updating second max when new max found  
2. ❌ Missing tie handling  
3. ❌ Using sorting (O(n log n))  

---

## 🔄 How to Think During Revision

When you see this problem:

1. "This is frequency problem"
2. "Track top 2 values"
3. "Handle tie carefully"

---

## 🧩 Summary (Quick Recall)

- Count frequency  
- Track max & second max  
- Return second  

---

## 🚀 Final Mental Model

👉 “Track best and second best simultaneously”

---

## 🔁 Pattern Connection

This problem uses:
- Hashing  
- Frequency counting  
- Top K pattern (K=2)  

Used in:
- Top K frequent elements  
- Ranking problems  
