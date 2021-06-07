# Shooting Dice

## A C# Exercise

### The Story

You are building a dice game. Like any good game, your game should have players. But you don't just want a single kind of player. No. You want your game to be interesting, so you want many types of players.

The goal of this exercise is to create classes to represent those various types of players and to write a `Program` class that will test them out.

### The Setup

1. Clone this repo.
1. Create a new repo under your github account.
1. Change the remote origin of the local repo to your new github repo.

### The Task

1. Read the existing code. Add or modify comments as needed to help you understand it.
1. Add code to each "Player" class to make it behave the way it should.
    * See the comment above each class for instructions. 
    * Complete the classes in the order specified below.
1. After completing each class, use it to create one or more Player objects in the `Main()` method. Write code to test these new objects.
1. Add the new Player object(s) to the `players` list, so they will be passed to the `PlayMany()` method.

> **NOTE:** Make sure to **FULLY TEST** each class immediately after you write it. Do **NOT** write all the classes before you test.

#### You should complete the classes in this order:

1. `SmackTalkingPlayer`
1. `OneHigherPlayer`
1. `HumanPlayer`
1. `CreativeSmackTalkingPlayer`
1. `SoreLoserPlayer`
1. `UpperHalfPlayer`
1. `SoreLoserUpperHalfPlayer`


# vocabulary
* type
    * set of constraints on values and variables 
    * The type of a value specifies what can be stored in a memory location
    * the type of a variable specifies what kind of thing can be stored in a variable
    * Examples
        * int
        * decimal
        * string
        * double
        * bool
        * `List<string>`
        * `List<bool>`
        * `Dictionary<string, bool>`
    * In C# you can define your own class
        * a `Person` class gives an oportunity to create a memory space for what we define as a `Person`
* Class
    * creates a new type
    * Defines the "shape" of an object
        * defines the properties and methods that an object will have
            * Public properties and methods are called "members"
    * Where do classes live?
        * Inside our source code (`*.cs`)
    * Blueprint for creating objects
        * a class is like a blueprint or cookie cutter
        * an "object" is like a house or a cookie
* Object
    * The real value that exists at run time.
    * Where do objects live?
        * Inside the running program
    * objects have value
    * Objects contain the properties, fields and methods defined inthe class
* Constructor
    * defined inside the class a special method that is invoked when the object is invoked
    * has the same name as a class
    * Invoked when you use the `new` keyword
    * Does not have a return type
    * You don't have to define a constructor if you don't need one.
    * If you don't define a constructor c sharp will define one for you called the default constructor.
    * You define a constructor when you need to perform some sort of action.
        * maybe some logic
        * maybe some field or property initialization
* Method
    * Defined in the class 
    * Exists in the object
    * Function that does something on or to the object
        * within the context of an object
* Property
    * value on an object
    * defined in class
    * Exists in object
    * has a type
    * properties are often `public`
    * Properties always have a `get`
        * returns rhe value
    * Properties usually have a `set` but don't have to.
        * Properties that don't have a `set` or imuttable or read only
    * properties are one way to contain the 'state' of the object
* Field
    * Feields are a way to store data on an object like properties and are value
    * Used when you only need the value in object or encapsulation