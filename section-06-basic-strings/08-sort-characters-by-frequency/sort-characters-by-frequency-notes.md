# 📘 Sort Characters by Frequency --- Revision Notes

---

## 🧠 Problem Summary

You are given a string `s`.

👉 Goal: - Sort characters based on: 1. **Higher frequency first** 2.
**Alphabetical order if frequencies are same**

---

## 📥 Example

    Input:  "tree"
    Output: ['e', 'r', 't']

Explanation:

- e → 2 times
- r → 1 time
- t → 1 time

Since `r` and `t` have same frequency → sort alphabetically → `r`, then
`t`

---

## 💡 Intuition (Very Important for Revision)

When you see this problem, think:

👉 "I need to sort based on TWO conditions"

1.  Frequency (primary)
2.  Alphabet (secondary)

So: - First count frequencies - Then apply **custom sorting**

---

## 🧱 Step-by-Step Solution

### STEP 1: Count frequency

    freq = {}

    for c in s:
        if c in freq:
            freq[c] += 1
        else:
            freq[c] = 1

Example:

    "tree" → {'t':1, 'r':1, 'e':2}

---

### STEP 2: Custom sort function

    def sort_key(ch):
        return (-freq[ch], ch)

### 🔍 Explanation (VERY IMPORTANT)

👉 Returns a tuple:

    (-frequency, character)

---

### ❓ Why negative frequency?

- Python sorts in **ascending order by default**
- But we want **higher frequency first**

So we do:

    -frequency

Example:

    e → 2 → (-2)
    t → 1 → (-1)

👉 Smaller number comes first → `-2` comes before `-1`

✅ So higher frequency comes first

---

### ❓ Why include `ch`?

👉 This is the **tie-breaker**

"If two characters have the same frequency, decide order using the
character itself (alphabetically)."

---

### ❌ If you only do this:

    return -freq[ch]

Problem:

    freq = {'t':1, 'r':1, 'e':2}

- 't' → -1
- 'r' → -1

👉 Python doesn't know which comes first 👉 Order becomes unpredictable
❌

---

### ✅ Correct approach:

    return (-freq[ch], ch)

Now:

    't' → (-1, 't')
    'r' → (-1, 'r')

Python compares:

1.  Compare -1 vs -1 → same
2.  Compare 'r' vs 't' → 'r' comes first

✅ Final order → `r`, `t`

---

## STEP 3: Sorting

    result = sorted(freq, key=sort_key)

### 🔍 What happens internally?

    sorted(['t', 'r', 'e'], key=sort_key)

Python does:

- Calls `sort_key()` for each character
- Gets tuples:

```{=html}
<!-- -->
```

    e → (-2, 'e')
    r → (-1, 'r')
    t → (-1, 't')

Then sorts:

    [(-2,'e'), (-1,'r'), (-1,'t')]

Final result:

    ['e', 'r', 't']

---

## 🎯 Sorting Priority (IMPORTANT)

1.  Frequency (descending using negative)
2.  Character (ascending)

---

## 🧾 Final Code

```python
def frequency_sort(s: str) -> list:
    freq = {}

    for c in s:
        if c in freq:
            freq[c] += 1
        else:
            freq[c] = 1

    def sort_key(ch):
        return (-freq[ch], ch)

    result = sorted(freq, key=sort_key)

    return result
```

---

## ⏱️ Time Complexity (Detailed)

Let: - `n` = length of string - `k` = number of unique characters

### Step 1: Counting frequency

    O(n)

👉 We loop through the string once

---

### Step 2: Sorting

    O(k log k)

👉 We sort only **unique characters**

---

### ✅ Total Time Complexity

    O(n + k log k)

---

## 🧠 Space Complexity

We store:

- `freq` dictionary → stores `k` unique characters

### Space Used

O(k)

Where:

- `k` = number of unique characters in the string

👉 Why?

- Each unique character is stored once in the dictionary
- No extra space proportional to `n` is used

---

## 🔁 How to Think During Revision

When you revisit this problem, ask:

1.  ❓ What is the requirement? → Sort by frequency + alphabetical

2.  ❓ What data structure helps? → Dictionary (for counting)

3.  ❓ How to sort by multiple conditions? → Use tuple in key

4.  ❓ Why negative? → To reverse sorting (descending)

5.  ❓ Why include character? → Tie-breaker

---

## 🚀 Final Mental Model

👉 "Convert problem into sorting rules"

    Sort by → (-frequency, character)
