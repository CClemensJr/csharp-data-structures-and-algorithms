# Graphs
> way to visualize data

## Challenge
```
	Implement a Graph!
```

## Approach and Efficiency
```
	For this datastructure I decided to use an array of arrays. I then used nested for
	loops to iterate though the arrays.

	Time: O(n^2)
	Space: O(n)
```

## API
### AddNodes()
> Adds a new node to the graph / Takes in the value of that node / Returns the added node

### AddEdge() 
> Adds a new edge between two nodes in the graph / Include the ability to have a �weight� / Takes in the two nodes to be connected by the edge / Both nodes should already be in the Graph

### GetNodes()
> Returns all of the nodes in the graph as a collection (set, list, or similar)

### GetNeighbors()
> Returns a collection of nodes connected to the given node / Takes in a given node / Include the weight of the connection in the returned collection

### Size()
> Returns the total number of nodes in the graph