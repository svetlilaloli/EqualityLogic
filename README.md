Exercise: Iterators and Comparators
# EqualityLogic

Create a __class Person__ holding a __name__ and an __age__. A person with the __same name__ and __age__ should be __considered__ the __same__. Override __any methods__ needed to enforce this logic. Your class should work with both __standard__ and __hashed__ collections. Create a __SortedSet__ and a __HashSet__ of type __Person__. You will receive __n__ – the number of input lines. On each of them, you will receive info about the people in the following format:

__"\<name\> \<age\>"__

You should __add__ the __people__ to __both__ the sets. In the end, you should print __the size__ of the __sorted set__ and then __the size__ of the __hashset__.
## Input
- On the first line of input you will receive a number __n__. 
- On each of the next __n__ lines you will receive information about people in the described format. 
## Output
- The output should consist of exactly two lines. 
- On the first one, you should print the size of the sorted set
- On the second - the size of the hashset.
## Constraints
- A person’s name will be a string that contains only alphanumerical characters with a length between __[1…50]__ symbols.
- A person’s age will be a positive integer between __[1…100]__.
- The number of people __N__ will be a positive integer between __[0…100]__.
## Examples
Input|Output
-----|------
4<br>Peter 20<br>Petter 20<br>George 15<br>Peter 21|4<br>4
7<br>John 17<br>john 17<br>Stoqn 25<br>John 18<br>John 17<br>Sam 25<br>Samm 25|5<br>5
