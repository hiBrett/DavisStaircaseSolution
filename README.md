## My solution to the HackerRank challenge "Recursion: Davis' Staircase"

Challenge Source: https://www.hackerrank.com/challenges/ctci-recursive-staircase

#### Description
You can climb a staircase by taking either one, two or three steps at a time. Given the numbe of stairs, find how many different ways there are to reach the top.

#### Solution
My strategy is to start from the top and work backwards. Each staircase we reach we will save the result from that point, that way we won't need to re-calculate it each time. Also, we will actually only need to save the results from the most recent three staircases as those are the only ones accessible to the current one.

### Steps
1. If there are less than three staircases, return the known answer.
2. Start with the fourth staircase. Store the most recent three staircase permutations. Thre first three are 1, 2, 4.
3. For each staircase calculate its permutation as being the addition of the most recent three.
4. Store that permutation as the most recent and delete the oldest.
5. Return the final permutation.

### Time and Space Complexity
The space complexity is O(1) because we are only storing the most recent three permutations.
<br/>The time complexity is O(n) because we are going through each stair once.

### Improvement Ideas
The function currently assumes that the person can jump up to three stairs at a time. The function could improved by taking the person's jumping ability as input.
