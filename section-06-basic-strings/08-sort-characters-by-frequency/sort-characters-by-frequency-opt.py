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


