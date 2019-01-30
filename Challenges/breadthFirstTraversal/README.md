# Breadth First Traversal

## Challenge
```
	Write a breadth first traversal method which takes a Binary Tree as its unique input. 
	Without utilizing any of the built-in methods available to your language, traverse 
	the input tree using a Breadth-first approach; print every visited node’s value.
```

## Example
|Input|Output|
|-----|-------|
| [3, 5, 15] | 3 5 15|
| [3, 5, 19]  | 3 5 19 |


## Approach and Efficiency
```
	For this problem I decided to use a queue to traverse through the tree level by level.
	At each level the nodes were enqueued and when they are dequeued the value is sent to 
	the console.

	Big O: Time: O(n), Space: O(W), where W is the width of the tree.
```

## Solution
![alt text](https://github.com/CClemensJr/data-structures-and-algorithms/blob/master/assets/breadthFirstTraversal1.JPG "Breadth First Traversal Part 1")
![alt text](https://github.com/CClemensJr/data-structures-and-algorithms/blob/master/assets/breadthFirstTraversal2.JPG "Breadth First Traversal Part 2")
