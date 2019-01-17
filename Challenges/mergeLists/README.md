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
	For this challenge I chose to use a loop to traverse the linked lists awhile a temp variable was not equal to null.
	During each iteration:
	* The temp variable is set to Current.Next (Current is originally set to the Head of the first linked list)
	* Current.Next is set to the head of link list 2
	* Set the head of link list 2 to temp
	* Set Current to Current.Next

Big O: Time: O(n), Space: O(1)
```

## Solution
![alt text](https://github.com/CClemensJr/data-structures-and-algorithms/blob/master/assets/mergeLists.JPG "Merge Linked Lists")
