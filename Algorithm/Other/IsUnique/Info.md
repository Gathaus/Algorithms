# Check for Unique Characters in a String

## Problem Type

Implement an algorithm to determine if a string has all unique characters.

## Methods

The following table summarizes the methods used, their difficulty level, and their complexities:

| Difficulty (out of 10) | Method Name  | Description                                                                                     | Space Complexity | Time Complexity |
|------------------------|--------------|-------------------------------------------------------------------------------------------------|------------------|-----------------|
| 3                      | Nested Loops  | Compares each character with every other character in the string.                                | O(1)             | O(n^2)          |
| 6                      | Sorting      | Sorts the string and then compares adjacent characters.                                          | O(1)             | O(n log n)      |
| 8                      | Bit Vector   | Sets a bit for each character and uses a bit vector to check for repeating characters.           | O(1)             | O(n)            |
| 7                      | Hash Set     | Adds each character to a hash set and checks for repeating characters.                           | O(n)             | O(n)            |

### Nested Loops

This is the simplest solution. We use two nested loops to compare each character with every other character in the string.

### Sorting

After sorting the string, we can easily check if any adjacent characters are the same. This is more efficient in terms of time complexity but requires an extra sorting step.

### Bit Vector

This approach sets a bit for each character and uses a bit vector to check for repeating characters. This is the most efficient method in terms of both time and space complexity but is a bit more difficult to implement.

### Hash Set

This method adds each character to a hash set and checks for repeating characters. This is efficient in terms of time complexity but uses extra space.

## Testing

The project includes xUnit tests to validate the correctness of each method.
