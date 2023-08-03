# C# Basics

## 10. Stack VS Heap memory

### Stack

The stack is like a stack of books. If you want to add a book (or in the case of a program, a value type variable or a method call), you put it on top of the stack. If you want to remove a book, you also take it from the top. This principle is often referred to as Last-In, First-Out (LIFO).

The stack is used to store local variables and method calls. Each time a method declares a new variable, it's "pushed" onto the stack. And each time a method exits, all of the variables pushed onto the stack by that method, are freed (they are "popped" from the stack). They disappear because they're automatically deallocated.

The memory allocation for stack is done at compile time, which makes it faster.

### Heap

The heap, on the other hand, is like a big pile of memory blocks. You can reach in and grab a block from anywhere in the pile. There's no inherent order like there is with a stack.

The heap is used to store instances of classes, i.e., objects. When you create a new object with the new keyword, a block of memory is allocated from the heap to store the object.

The reference to the object, which is a pointer to the block of memory in the heap, is then stored on the stack. It's a bit like writing down the location of a specific block in the pile on a piece of paper (the stack).

Unlike the stack, memory in the heap needs to be managed. Once you've allocated a block and you're done with it, you need to deallocate it. If you don't, this can lead to memory leaks and eventually cause the program to run out of memory. However, in languages like C#, the garbage collector will periodically deallocate objects from the heap that are no longer in use.

In general, operations on the heap are slower because of the extra work involved in memory management (and due to the fact that the heap can be much larger).

## 11. Value Type

In C#, types are divided into two main categories: Reference type and Value type.

Value types directly contain their data in `Stack` memory. Examples of value types are all the primitive data types like int, char, float, double, etc., and struct. If you change the data of one variable, it doesn't affect other variables because they hold their own copy of the data.

```csharp
int num1 = 10;
int num2 = num1;
num1 = 20;
Console.WriteLine(num2); // Outputs "10", because num2 has its own copy of the value.
```

| Stack   | Heap |
| ------- | ---- |
| num1:10 |      |
| num2:20 |      |

## 12. Reference Type

Reference types are used to store references to the actual data. The reference in `Stack` memory points to the location where the data is stored in `Heap`. Classes, arrays, interfaces, and delegates are examples of reference types. If you modify the data of a reference type variable, the change is reflected in all other variables that reference the same object.

```csharp
Car car1 = new Car(); // car1 is a reference to a Car object.
Car car2 = car1; // car2 is now a reference to the same object that car1 refers to.
car1.color = "blue"; // change the color of the car through car1.
Console.WriteLine(car2.color); // Outputs "blue", because car1 and car2 reference the same object.
```

| Stack      | Heap                    |
| ---------- | ----------------------- |
| car1:ref-1 | ref-1:Car{color="blue"} |
| car2:ref-1 |                         |

## 13. Class and Object

### Class

Think of a class like a blueprint for a building. This blueprint is a plan that shows what the building will look like when it's completed, including all of the rooms, doors, windows, and other details. In C#, a class is like a blueprint for an object. It describes what the object will look like and what it can do.

```csharp
public class Building
{
    //Fields
    private string _address;
    private int _floors;

    //Properties
    public string Address
    {
        get
        {
            return _address;
        }
        set
        {
            _address = value;
        }
    }

    public int Floors
    {
        get
        {
            return _floors;
        }
        set
        {
            _floors = value;
        }
    }

    // Method
    public void DisplayBuildingInfo()
    {
        Console.WriteLine($"Address: {_address}, Floors: {_floors}");
    }
}
```

### Object

An object is like a building that has been constructed from a blueprint. It's a specific example that's been created from the plan.

Objects can be created by using the `new` keyword followed by the name of the class, like this:

```csharp
Building building1 = new Building();
building1.Address = "123 Main Street";
building1.Floors = 5;

Building building2 = new Building();
building2.Address = "456 Elm Street";
building2.Floors = 10;
```
