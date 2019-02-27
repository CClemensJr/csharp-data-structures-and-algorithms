# Get Edges

## Challenge
> Given a business trip itinerary, and an Alaska Airlines route map, is the trip possible with direct flights? 
  If so, how much will the total trip cost be?
  
> Write a method which takes in a graph and an array of city names. 
  Without utilizing any of the built-in methods available to your language, 
  return whether the full trip is possible with direct flights, and how much it would cost.

## Example
|Input|Output|
|-----|-------|
| (Seattle)-$150-(Spokane) | (true, $150) |

## Approach and Efficiency
```
	For this problem I decided to use a while loop over the entire graph 
	with a nested for loop to compare the children of each node.

	Big O: Time: O(n^2), Space: O(w)
```

## Solution
![alt text](https://github.com/CClemensJr/data-structures-and-algorithms/blob/master/assets/breadthFirstTraversalOfGraph.JPG "Get edges")

