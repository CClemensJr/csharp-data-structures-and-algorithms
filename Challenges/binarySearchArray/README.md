# Search through an Array with the Binary Search Algorithm

## Challenge
```
Write a function called BinarySearch which takes in 2 parameters: a sorted array and the search key. Without utilizing any of the built-in methods available to your language, return the index of the array’s element that is equal to the search key, or -1 if the element does not exist.
```

##Example
|Input|	Output|
|-----|-------|
| [4, 8, 15, 16, 23, 42], 15 | 2 |
| [11, 22, 33, 44, 55, 66, 77], 90 | -1 |

##Approach and Efficiency
```
For the Binary Search algorithm I chose a do-while loop to avoid unnecessary iteration if the search key existed in the middle of the sorted array. 
If not, the left or right boundaries were adjusted based the search key being larger or smaller than the value at the midpoint. The iteration began 
with the midpoint adjusted to the new boundaries, then repeated the process of evaluation and boundary redefinition as appropriate. Once the search 
key was found, the index was returned. Otherwise the function returned -1 to indicate that the search key did not exist in the array.

Big O: O(log n)
```

##Solution
![alt text](https://github.com/CClemensJr/data-structures-and-algorithms/blob/master/assets/binarySearchArray.jpeg "Binary Search Whiteboard")