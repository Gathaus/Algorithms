# String Compression Methods

| Rank | Method                            | Difficulty (out of 10) | Space Complexity | Time Complexity |
|------|-----------------------------------|------------------------|------------------|-----------------|
| 1    | Iterate with Pointers             | 3                      | O(1)             | O(n)            |
| 2    | Using Built-in Libraries          | 5                      | O(n)             | O(n)            |
| 3    | Recursion                         | 7                      | O(n)             | O(n^2)          |

## 1. Iterate with Pointers

### How to Implement:
- Initialize two pointers: `start` and `end`. Both will start at the beginning of the string.
- Iterate through the string. `end` pointer will move forward until a different character from `start` is encountered.
- Count the difference between `end` and `start` to determine how many times the character at `start` position was repeated.
- Append the character from the `start` position and its count to the result string.
- Move the `start` pointer to the `end` pointer position and repeat the process until the end of the string is reached.
- Compare the length of the compressed string with the original string. Return the shorter one.

## 2. Using Built-in Libraries

### How to Implement:
- Utilize built-in libraries such as `groupby` from itertools to group consecutive repeated characters.
- Iterate over the groups, append the character and its count to the result string.
- Compare the length of the compressed string with the original string. Return the shorter one.

## 3. Recursion

### How to Implement:
- Base case: if the string is empty, return an empty string.
- Recursive step: find the count of the first character. Append the character and its count to the result string. Then, call the function recursively on the remaining part of the string that hasn't been processed.
- At the end of the recursion, compare the length of the compressed string with the original string. Return the shorter one.

# Tips and Recommendations:
1. **Edge Cases**: Always check for edge cases like empty strings or strings with single characters.
2. **Efficiency**: The iterative method with pointers is generally more efficient because it avoids extra overhead from using built-in libraries or recursive calls.
3. **Space Complexity**: Always keep an eye on space usage. The requirement here is to return a compressed string only if it's smaller. So, if during compression, the result string becomes equal to or larger than the original, you can break early.
4. **Immutable Strings**: In some programming languages (like Python), strings are immutable. This means that each string modification will create a new string. To optimize for such languages, consider using a list or a similar data structure to build the compressed string and then convert it to a string at the end.
5. **Pre-counting**: Before starting compression, you can iterate over the string to count how many compression opportunities exist (how many groups of repeated characters). If there aren't enough to make the compressed string shorter, you can return the original immediately without compression.
