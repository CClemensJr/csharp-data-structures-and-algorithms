# Find the Kth Node From The End of a Linked List

## Challenge
```
	Write a method for the Linked List class which takes a number, k, as a parameter. 
	Return the node's value that is k from the end of the linked list.
```

## Example
|Input|Args|Output|
|-----|-------|
| [4]-> [8]-> [15]-> [16]-> [23]-> [42]-> X | 0 | 42 |
| [4]-> [8]-> [15]-> [16]-> [23]-> [42]-> X | 3 | 15 |

## Approach and Efficiency
```
For this algorithm I chose to first call a method that iterates over the linked list and then counts the nodes. Once this is found the list is iterated over
until the last node - k is reached. Then the value is returned. a

Big O: Time: O(n), Space: O(1)
```

## Solution
![alt text](https://github.com/CClemensJr/data-structures-and-algorithms/blob/master/assets/kthFromTheEnd.JPG "Kth From End Whiteboard")
