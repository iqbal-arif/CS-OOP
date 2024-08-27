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



**Object-Oriented-Programming**

Q1: Name one benefit of using object-oriented programming
A1: Encapsulation - it's easy to get going since complexity is typically hidden behind an API.

Q2: What best describes a class?
A2: A "blueprint" from which objects/instances can be created.

Q3: What best describes an object/instance?
A3: A manifestation of a class, created by calling a constructor.

Q4: How many objects/instances of a class are typically created in a program?
A4: Strange question - however many we need.

Q5: Which is the only type of class member in which time-consuming operations are expected?
A5: Methods

**Inheridtance**

Q1: What members are inherited when deriving from a base-class?
A1: All non-private members except for constructors

Q2: Which class is at the “top” of each inheritance chain?
A2: Object.

Q3: How many direct base classes can a class have in C#?
A3: One

Q4: If class Employee inherits class Person, and Person has a constructor that takes in a name, what must Employee do?
A4: Any constructor in Employee must call a constructor in Person, passing along name.

Q5: What does it mean for a class to be abstract?
A5: The class can be inherited from, but not instanstiated.

