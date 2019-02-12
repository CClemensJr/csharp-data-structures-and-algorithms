# Calculate the Height of a Binary Tree

## Challenge
```
	Implement a method with the following signature int CalculateBinaryTreeHeight(Node root) 
	that calculates the height of a binary tree.
```

## Example
|Input|Output|
|-----|-------|
| (1) (2)(3) (4)(5)(6)(7) | height = 2 |
| (1) (2)(3) (4)(5)(6)(7) (8)(10) | height = 3 |


## Approach and Efficiency
```
	For this problem I decided to use a breadth first approach to traverse through the tree.
	When a new layer of the tree is added to the queue, the height variable is increased by one.
	When traversal is complete, the height variable is returned.

	Big O: Time: O(n), Space: O(w)
```

## Solution
![alt text](https://github.com/CClemensJr/data-structures-and-algorithms/blob/master/assets/calculateBinaryTreeHeight.JPG "Calculate Binary Tree Height")

