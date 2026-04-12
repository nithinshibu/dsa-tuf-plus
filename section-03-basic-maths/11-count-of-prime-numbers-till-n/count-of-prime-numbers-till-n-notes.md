# Count Prime Numbers Till N (DSA) – Detailed Revision Notes

## 🧠 Problem Statement
Given an integer `n`, count how many **prime numbers** exist from `1 → n`.

---

## 📌 Examples

- Input: `n = 10` → Output: `4`
  (Primes: 2, 3, 5, 7)

- Input: `n = 5` → Output: `3`
  (Primes: 2, 3, 5)

---

## 💡 Intuition (Very Simple Thinking)

👉 We already know how to check:
"Is a number prime?"

Now just:
1. Loop from `2 → n`
2. Check each number
3. Count how many are prime

---

## 🔁 Core Idea

- Use `isPrime()` function
- Loop from `2 → n`
- Increment count if prime

---

## ⚙️ Step-by-Step Execution

### Input:
```
n = 10
```

### Iteration:

- 2 → prime → count = 1  
- 3 → prime → count = 2  
- 4 → not prime  
- 5 → prime → count = 3  
- 6 → not prime  
- 7 → prime → count = 4  
- 8 → not prime  
- 9 → not prime  
- 10 → not prime  

---

### Final Answer:
```
4
```

---

## 🧾 Final Code (C#)

```csharp
class Solution
{
    public bool isPrime(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    public int primeUptoN(int n)
    {
        int cnt = 0;

        for (int i = 2; i <= n; i++)
        {
            if (this.isPrime(i))
                cnt++;
        }

        return cnt;
    }
}
```

---

## 🎯 Key Insight

👉 This is a **nested pattern problem**:
- Outer loop → iterate numbers
- Inner logic → prime check

---

## 🧮 Time Complexity (Detailed)

### isPrime(n):
```
O(√n)
```

### primeUptoN(n):
- Loop runs `n` times
- Each time calls `isPrime()`

```
Total Time = n × √n
```

```
Time Complexity = O(n√n)
```

---

## 💾 Space Complexity (Detailed)

We only use:
- counter
- loop variables

```
Space Complexity = O(1)
```

---

## ⚠️ Important Observation (Optimization Insight)

👉 This solution is NOT optimal for large `n`

Better approach:
- Sieve of Eratosthenes → O(n log log n)

---

## ⚠️ Common Mistakes

1. ❌ Starting from 1 (1 is not prime)
2. ❌ Not using optimized prime check
3. ❌ Forgetting √n optimization

---

## 🔄 How to Think During Revision

When you see this problem:

1. "I need to count primes"
2. "Loop from 2 to n"
3. "Reuse prime check function"

---

## 🧩 Summary (Quick Recall)

- Loop → 2 to n
- Check prime
- Count

---

## 🚀 Final Mental Model

👉 “Check each number and count primes”

---

## 🔁 Pattern Connection

This problem uses:
- Looping over range
- Prime checking
- Nested complexity

Next upgrade:
👉 Sieve of Eratosthenes (VERY IMPORTANT)
