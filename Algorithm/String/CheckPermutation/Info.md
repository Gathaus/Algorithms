# Check Permutation: Given two strings, decide if one is a permutation of the other

## Problem Type

Implement an algorithm to determine if two given strings are permutations of each other.

## Methods

The following table summarizes the methods used, their difficulty level, and their complexities:

| Difficulty (out of 10) | Method Name       | Description                                                 | Space Complexity | Time Complexity |
|------------------------|-------------------|-------------------------------------------------------------|------------------|-----------------|
| 2                      | Sort and Compare  | Sort both strings and then compare them.                     | O(n)             | O(n log n)      |
| 4                      | Hash Table        | Use a hash table to count occurrences of each character.     | O(n)             | O(n)            |
| 5                      | Array Count       | Use an array to count occurrences of each character.         | O(1)             | O(n)            |

### Sort and Compare

1. Sort both strings.
2. Compare the sorted strings to see if they are identical.

### Hash Table

1. Create a hash table to keep track of the character counts for the first string.
2. Iterate over the second string, decrementing the counts in the hash table.
3. Check if all counts in the hash table have returned to zero.

### Array Count

1. Create an array of fixed size (e.g., 128 for ASCII characters).
2. Iterate over the first string, incrementing the array counts.
3. Iterate over the second string, decrementing the array counts.
4. Check if all counts in the array have returned to zero.

## Testing

The project includes unit tests to validate the correctness of each method.
