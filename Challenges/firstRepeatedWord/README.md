# Find the Maximum Value In A Binary Tree

## Challenge
```
	Write a function called find-maximum-value which takes binary tree as its only input.
	Without utilizing any of the built-in methods available to your language, return the 
	maximum value stored in the tree. You can assume that the values stored in the Binary 
	Tree will be numeric.
```
## Example
|Input|Output|
|-----|-------|
| [(3), (5), (15)] | 15 |
| [(3), (55), (19)]  | 55 |

## Approach and Efficiency
```
	For this problem I decided to use breadth first traversal to traver the tree level by 
	level. The max value is initially set to 0 and is updated when a traversed node is
	greater the current max value. The max value is returned after the entire tree has
	been traversed.

	Big O: Time: O(n), Space: O(W), where W is the width of the tree.
```

## Solution
![alt text](https://github.com/CClemensJr/data-structures-and-algorithms/blob/master/assets/findMaxValBinaryTree1.jpeg "Find Max Value in a Binary Tree Part 1")
![alt text](https://github.com/CClemensJr/data-structures-and-algorithms/blob/master/assets/findMaxValBinaryTree2.jpeg "Find Max Value In a Binary Tree Part 2")
