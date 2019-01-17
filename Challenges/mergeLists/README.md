# Merge Two Linked Lists

## Challenge
```
	Write a method for the Linked List class which takes two linked lists as arguments. Zip the two linked lists together into one
	so that the nodes alternate between the two lists and return a reference to the head of the zipped list.
```

## Example
|Input|Output|
|-----|-------|
| head-> [4]-> [8]-> [15]-> X, | head-> [4]-> [2]-> [8]-> [7]-> [15]-> [12]-> X |
| head-> [2]-> [7]-> [12]-> X  

## Approach and Efficiency
```
For this algorithm I chose to first call a method that iterates over the linked list and then counts the nodes. Once this is found the list is iterated over
until the last node - k is reached. Then the value is returned. a

Big O: Time: O(n), Space: O(1)
```

## Solution
![alt text](https://github.com/CClemensJr/data-structures-and-algorithms/blob/master/assets/mergeLists.JPG "Kth From End Whiteboard")
