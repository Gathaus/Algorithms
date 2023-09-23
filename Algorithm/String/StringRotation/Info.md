# String Rotation Problem Solutions

## Table of Potential Solutions

| Method Name              | Difficulty (out of 10) | Time Complexity | Space Complexity |
|--------------------------|------------------------|-----------------|------------------|
| Concatenate and Check    | 4                      | O(N)            | O(N)             |
| Index Rotation & Check   | 7                      | O(N^2)          | O(1)             |

---

## Methods Detailed Explanation

### 1. Concatenate and Check

#### Description
This method involves concatenating the string `s1` with itself. If `s2` is truly a rotation of `s1`, then it should be a substring of the new concatenated string.

#### Implementation Steps
1. Concatenate `s1` with itself.
2. Use the `isSubstring` method to check if `s2` is a substring of the concatenated string.

---

### 2. Index Rotation & Check

#### Description
Rotate `s1` for every character from the beginning and compare it to `s2`. It is less efficient than the first method but requires no additional space.

#### Implementation Steps
1. For each index `i` in `s1`:
    1. Rotate `s1` to start from index `i`.
    2. Check if the rotated string equals `s2` using string comparison. If a match is found at any iteration, return `true`.
2. If no match is found after iterating through all indices, return `false`.

---

## General Tips for Rotation Algorithms
1. **String Length Check:** Always check if the lengths of the two strings are equal before attempting any rotation logic. If they aren't the same length, one cannot be a rotation of the other.
2. **Substring Utility:** If you're allowed to use a substring checking utility, try to think of ways to leverage it to simplify the rotation problem.
3. **Avoid Multiple Substring Calls:** The problem statement emphasizes using `isSubstring` only once. Always try to respect such constraints as they might be indicative of the optimal solution's nature.
4. **Boundary Conditions:** Be careful with boundary conditions when working with rotations, especially if you're working with string indices.
5. **Efficiency:** Consider the efficiency of the algorithm in terms of both time and space. Often there might be trade-offs between the two.
