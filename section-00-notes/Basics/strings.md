# 📘 Strings — Complete DSA Notes

---

# 🔹 What is a String?

👉 A **string** is a sequence of characters used to store text.

```csharp
string s = "hello";
```

👉 Internally:

- It is like an **array of characters**
- Stored in **continuous memory**

---

# 🔹 Important Property in C#

## ❗ Strings are IMMUTABLE

👉 Once created, you **cannot modify it directly**

```csharp
string s = "hello";
s[0] = 'H';  // ❌ Not allowed
```

👉 Any modification creates a **new string**

```csharp
string s = "hello";
s = s + " world";  // new string created
```

---

# 🔹 String vs Char

| Type   | Example |
| ------ | ------- |
| String | "hello" |
| Char   | 'h'     |

```csharp
char c = 'a';
string s = "abc";
```

---

# 🔹 Accessing Characters

```csharp
string s = "hello";

char ch = s[1];  // 'e'
```

👉 Indexing is **0-based**

---

# 🔹 Traversing a String

---

## ✅ Using for loop

```csharp
for(int i = 0; i < s.Length; i++)
{
    Console.WriteLine(s[i]);
}
```

---

## ✅ Using foreach

```csharp
foreach(char c in s)
{
    Console.WriteLine(c);
}
```

---

# 🔹 Time Complexity Basics

| Operation     | Complexity |
| ------------- | ---------- |
| Access char   | O(1)       |
| Traverse      | O(n)       |
| Concatenation | O(n)       |
| Substring     | O(n)       |

---

# 🔹 Important Concept: ASCII

👉 Every character has a number

| Character | ASCII |
| --------- | ----- |
| 'a'       | 97    |
| 'A'       | 65    |

---

## 🔹 Useful Trick

```csharp
int index = 'c' - 'a';  // 2
```

👉 Used in:

- Frequency counting
- Hashing

---

# 🔹 Substring

👉 A part of string

```csharp
string s = "hello";

string sub = s.Substring(1, 3);  // "ell"
```

👉 Format:

```text
Substring(startIndex, length)
```

---

# 🔹 String vs Char Array

```csharp
string s = "hello";
char[] arr = s.ToCharArray();
```

👉 Use char array when:

- You need to modify characters

---

# 🔹 Common Patterns in DSA

---

## 🟢 1. Frequency Counting (Very Important)

```csharp
string s = "hello";

var freq = new Dictionary<char, int>();

foreach(char c in s)
{
    if(freq.ContainsKey(c))
        freq[c]++;
    else
        freq[c] = 1;
}
```

---

## 🟢 Optimized (Using Array)

```csharp
int[] hash = new int[26];

foreach(char c in s)
{
    hash[c - 'a']++;
}
```

---

## 🔵 2. Two Pointer Technique

👉 Used in palindrome problems

```csharp
int left = 0;
int right = s.Length - 1;

while(left < right)
{
    if(s[left] != s[right])
        return false;

    left++;
    right--;
}
```

---

## 🟡 3. Sliding Window (Important)

👉 Used for substring problems

```csharp
var set = new HashSet<char>();

int left = 0;

for(int right = 0; right < s.Length; right++)
{
    while(set.Contains(s[right]))
    {
        set.Remove(s[left]);
        left++;
    }

    set.Add(s[right]);
}
```

👉 Used in:

- Longest substring without repeating characters

---

## 🟠 4. Reverse String

```csharp
char[] arr = s.ToCharArray();

Array.Reverse(arr);

string result = new string(arr);
```

---

## 🔴 5. Palindrome Check

```csharp
string s = "madam";

int left = 0, right = s.Length - 1;

while(left < right)
{
    if(s[left] != s[right])
        return false;

    left++;
    right--;
}

return true;
```

---

# 🔹 Important Problem Types

---

## ✅ 1. Anagram Check

```csharp
string s1 = "listen";
string s2 = "silent";

if(s1.Length != s2.Length) return false;

int[] count = new int[26];

foreach(char c in s1) count[c - 'a']++;
foreach(char c in s2) count[c - 'a']--;

return count.All(x => x == 0);
```

---

## ✅ 2. Count Characters

👉 Already covered using hashing

---

## ✅ 3. Longest Substring

👉 Use sliding window

---

## ✅ 4. String Matching

- `Contains`
- `IndexOf`

```csharp
s.Contains("he");
```

---

# 🔹 Important Interview Tips

---

## ⚡ 1. Strings = Arrays

👉 Always think:

```text
String problem = Array problem
```

---

## ⚡ 2. Use Right Tool

| Problem Type | Technique        |
| ------------ | ---------------- |
| Frequency    | Hashing          |
| Palindrome   | Two pointers     |
| Substring    | Sliding window   |
| Matching     | Built-in methods |

---

## ⚡ 3. Avoid String Concatenation in Loops

❌ Bad:

```csharp
string result = "";

for(int i = 0; i < n; i++)
    result += s[i];
```

👉 O(n²)

---

## ✅ Use StringBuilder

```csharp
var sb = new StringBuilder();

foreach(char c in s)
    sb.Append(c);

string result = sb.ToString();
```

👉 O(n)

---

# 🔹 Common Mistakes

❌ Forgetting immutability
❌ Off-by-one errors
❌ Using string instead of char[] when modifying
❌ Not considering case sensitivity

---

# 🔹 Space Complexity

| Case           | Complexity |
| -------------- | ---------- |
| No extra space | O(1)       |
| New string     | O(n)       |
| Hashing        | O(n)       |

---

# 🔹 Final Summary

- Strings = array of characters
- Immutable in C#
- Most problems use:
  - Hashing
  - Two pointers
  - Sliding window

---

# 🎯 Closing Thought

👉 If you master strings, you unlock:

- Pattern matching
- Sliding window problems
- Interview-level questions

---
