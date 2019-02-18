# Hashtables
> one of the most common data structures for sifting through data.

## Challenge
```
	Implement a Hashtable.
```

## Approach and Efficiency
### To Be Added
```
	A binary tree is unordered so to find a value the whole tree may need to be searched.
	Recursion is used to go traverse through the tree. This results in:

	Time: O(N)
	Space: O(H), where H is the height of the tree
```

## API
### add
> takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed.

### get 
> takes in the key and returns the value from the table.

### contains
> takes in the key and returns a boolean, indicating if the key exists in the table already.

### hash
> takes in an arbitrary key and returns an index in the collection.
