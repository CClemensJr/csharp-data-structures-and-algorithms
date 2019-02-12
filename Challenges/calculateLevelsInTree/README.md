# Calculate the Number of Levels for a Tree

## Challenge
```
	Implement a method that calculates the number of levels in a tree.
```

## Example
|Input|Output|
|-----|-------|
| (1) (2)(3) (4)(5)(6)(7) | levels = 3 |
| (1) (2)(3) (4)(5)(6)(7) (8)(10) | levels = 4 |


## Approach and Efficiency
```
	For this problem I decided to use a breadth first approach to traverse through the tree.
	When a new layer of the tree is added to the queue, the level variable is increased by one.
	When traversal is complete, the level variable is returned.

	Big O: Time: O(n), Space: O(w)
```

## Solution
![alt text](https://github.com/CClemensJr/data-structures-and-algorithms/blob/master/assets/calculateLevelsInTree.JPG "Calculate Binary Tree Height")

