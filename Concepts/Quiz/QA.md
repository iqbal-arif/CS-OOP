**Classes**

Q1. Which one of these statements is true regarding classes?
A1. A class is a collection of logically related members (such as methods).

Q2: Which one of these statements is true regarding objects?
A2: An Object represents a specific instance of a class.

Q3: What is a constructor?
A3: A special class member used to create an object of the class.

Q4: What does the this keyword represent?
A4: The current object / instance of a class.

Q5: A private member can...
A5: Be called from within the class itself.

Q6: A public member can...
A6: Be called within the class itself and on an object of the class.

Q7: Static members are..
A7: Called directly on the class.


**Array**

Q1: When is it appropriate to use an array?
A1: When we need to represent a series of related values.

Q2: What index is used to access the first item in an array?
A2: 0

Q3: What code would access the last value of the names array?
A3: names[names.Length - 1]

Q4: What will be written on the console given the following code?

```
string[] names = { "Bo", "Li", "An" };

Console.WriteLine(names[1]);
```
A4: Li

Q5: What will be printed on the console given the following code?

```
string[] names = { "Bo", "Li", "An" };

Array.Reverse(names);


Console.WriteLine(names[names.Length - 1]);
```
A5: Bo

Q6: Which loop is typically used to iterate over an array (if we need to know the index of the iteration)?
A6: The for loop.


**Properties**

Q1: Name one benefit that properties offer over a public field/class variable
A1: Values can be validated before assignment.

Q2: If C# didn't support properties, we could get the same functionality using...
A2: Get/Set methods used fro providing read/write access to a field/class variable.

Q3: The following is true regarding automatic properties:
A3: They provide a more terse (smooth) syntax than traditional / full properties.

