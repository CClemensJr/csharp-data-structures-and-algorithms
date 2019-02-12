# Remove duplicated values from a linked list

## Challenge
```
	Implement a method with the following signature LinkedList RemoveDuplicatens(LinkedLst list) 
	that removes all duplicated values from the linked list. The modifications must happen in place. 
```

## Example
|Input|Output|
|-----|-------|
| 1 -> 2 -> 3 -> 1 | 1 -> 2 -> 3 |
| 1 -> 2 -> 3 -> 2 -> 1 -> 3 | 1 -> 2 -> 3 |


## Approach and Efficiency
```
	For this problem I decided to nested while loops to compare each node in the
	linked list to each other node.

	Big O: Time: O(n^2), Space: O(1)
```

## Solution
![alt text](https://github.com/CClemensJr/data-structures-and-algorithms/blob/master/assets/removeDuplicates.JPG "Remove Duplicate Nodes")

