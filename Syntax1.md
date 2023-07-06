# C# Basics for Python Developers #1

## 0. Testing Code Using dotnet Console Command

We begin with understanding how to run C# code. Unlike Python which has an interpreter, C# requires a compiler to translate its code into machine language. The .NET Core command-line interface (CLI) is a powerful tool for creating, restoring packages, building, running, and publishing .NET applications. Follow these steps to create and run a C# application:

1. Open a terminal or command prompt.
2. Navigate to the directory where you want to create the console application.
3. Run the following command to create a new console application project:

```
dotnet new console -n MyConsoleApp_Or_Any_Other_Name
```

This command creates a new console application project named "MyConsoleApp".

4. Open the project folder in your preferred code editor (e.g., Visual Studio Code).
5. Replace the contents of the generated Program.cs file with your C# code.
6. Save the file.

To run the code, go back to the terminal or command prompt and navigate to the project folder.

```
cd MyConsoleApp_Or_Any_Other_Name_You_Used
```

Use the following command to run the project:

```
dotnet run
```

## 1. Variables and Types

In Python, variables are dynamically typed, meaning their type is inferred at runtime. In C#, every variable has a type, which must be defined when the variable is declared. C# is a statically typed language, which means the type of a variable is known at compile-time.

Python:

```python
name = "John"
age = 20
is_student = True
```

C#:

```csharp
string name = "John";
int age = 20;
bool isStudent = true;
```

In C#, variables have to be declared with a specific data type. The data type is determined when the variable is declared and cannot be changed later.

C# also allows nullable types, enums, and list initializations which are a bit different from Python.

```csharp
// Declare a nullable int variable and assign it a null value.
// This means the variable can hold either an integer or null.
// This is different from Python where every variable can hold a None.
int? nullableInt = null;

// Declare an enum named DaysOfWeek.
// Enums are used to declare a type that can have a set of distinct values.
// This is similar to Python's enum.Enum, but in C#, enum is a built-in feature.
enum DaysOfWeek
{
    Monday,    // Each line represents a distinct value.
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
};

// Declare a list of integers named numbers and initialize it with a set of values.
// The List<T> is a built-in generic collection in C#.
// It's similar to Python's list but it can only hold values of the same type.
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
```

## 2. Constants

Constants are a type of variable whose value cannot be changed after it's initially set. In Python, the convention is to use uppercase letters for constant names, while in C#, you use the `const` keyword before the variable type.

Python:

```python
NAME = "John"
```

C#:

```csharp
const string Name = "John";
Name = "Cat"; // This will cause a compile error
```

## 3. Arrays

Arrays in C# are similar to lists in Python, but they have a fixed size and can only contain elements of the same type.

Python:

```python
numbers = [1, 2, 3, 4, 5]
```

C#:

```csharp
int[] numbers = new int[] {1, 2, 3, 4, 5};
```

You can also create an array with a fixed size, and then assign values to each element:

````csharp
int[] arrayWithSize = new int[5];  // Array with size 5
arrayWithSize[0] = 1;  // Assign value 1 to the first element
arrayWithSize[1] = 2;```
// Assign value 2 to the second element
arrayWithSize[4] = 5;  // Assign value 5 to the fifth element

// Accessing the value
int firstNumber = numbers[0];  // Accessing the first element (1)
int thirdNumber = numbers[2];  // Accessing the third element (3)
int size = arrayWithSize.Length;  // Get the length of the arra
````

## 4. Control Flow

In C#, we use `if`, `else if`, and `else` statements for conditional logic. However, C# requires parentheses `()` around the condition, and braces `{}` around the block of code to be executed.

Here, we introduce comparison operators (e.g., ==, !=, <, <=, >, >=) and logical operators (e.g., `&&` for logical AND, `||` for logical OR).

Python:

```python
if is_student:
    print("Hello, student!")
elif age > 30:
    print("Hello, sir!")
elif age >= 18 and age <= 30:
    print("Hello, young adult!")
else:
    print("Hello!")
```

C#:

```csharp
if (isStudent)
{
    Console.WriteLine("Hello, student!");
}
else if (age > 30)
{
    Console.WriteLine("Hello, sir!");
}
else if (age >= 18 && age <= 30)
{
    Console.WriteLine("Hello, young adult!");
}
else
{
    Console.WriteLine("Hello!");
}
```

Another useful operator is the "not equal" operator (!=), which returns true if the two operands are not equal:

```csharp
if (age != 25)
{
    Console.WriteLine("Your age is not 25.");
}
```

Also, C# supports the negation operator (!) to reverse the logical value of the operand:

```csharp
bool isStudent = false;
if (!isStudent)  // That means, If isStudent doesn't have 'true' boolean value
{
    Console.WriteLine("You are not a student.");
}
```

## 4-1 Switch

The switch statement is a selection statement in C# that chooses a single switch section to execute from a list of candidates based on a pattern match with the match expression. It's often used as an alternative to if-else statements when you need to test a variable against a series of values.

Here is a template

```csharp
switch (expression)
{
    case value1:
        // statement sequence
        break;   // this line ends the switch case
    case value2:
        // statement sequence
        break;
    // you can have any number of case statements.
    default: //optional
        // statement sequence
        // This code is executed if none of the previous cases are satisfied
        break;
}
```

And here is a example

```csharp
int num = 3;

switch (num)
{
    case 1:
        Console.WriteLine("One");
        break;
    case 2:
        Console.WriteLine("Two");
        break;
    case 3:
        Console.WriteLine("Three");
        break;
    default:
        Console.WriteLine("Invalid number");
        break;
}
```

In this code, `num` is the switch expression that is tested against all the different case values. If the value of `num` matches a case value, then the corresponding block of code is executed. If it doesn't match any case values, the default block is executed.

Also, note that each case ends with a `break` statement. This is necessary to ensure that once a matching case block is found and its statements are executed, control is transferred out of the switch statement. If you forget to include a break statement, you will get a compile error.

The `default` case is optional and can be used to execute a block of code when the switch expression doesn't match any of the case values. If the `default` case is omitted and there's no match, no action is taken and execution continues at the statement following the switch statement.

## 5. Loops

C# has `for`, `while`, and `do-while` loops, similar to Python. However, there are some syntax differences to note.

Python:

```python
for number in numbers:
    print(number)

i = 0
while i < 5:
    print(i)
    i += 1
```

C#:

```csharp
int[] numbers = new int[] {1, 2, 3, 4, 5};

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i += 1;
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

for (int j = 10; j >= 0; j--)
{
    Console.WriteLine(j);
}

```

## 6. Ternary Operator

The ternary operator (?:) works like a shorthand `if-else` statement. The syntax is `condition ? consequence : alternative`. If the condition is true, the consequence is executed, else the alternative is executed. Here's an example:

Python:

```python
message = "Hello, student!" if is_student else "Hello, visitor!"
```

C#:

```csharp
string message = isStudent ? "Hello, student!" : "Hello, visitor!";
Console.WriteLine(message);
```

## 7. Increment and Decrement Operators

In C#, you can use the `++` and `--` operators to increase or decrease a value by one. This can be useful in loops and other situations where you need to change a value in a regular way.

Prefix increment (++i) or decrement (--i) operators change the value of the variable i first and then return the value. For example, if i is 5, ++i will change i to 6 and then return the value 6.
Postfix increment (i++) or decrement (i--) operators return the value of the variable i first and then change the value. For example, if i is 5, i++ will return the value 5 and then change i to 6.

C#:

```csharp
int i = 5;
int j = ++i;  // Prefix increment: i is incremented to 6 and then j is assigned the value 6.
Console.WriteLine($"i: {i}, j: {j}");  // Outputs "i: 6, j: 6"

i = 5;
j = i++;  // Postfix increment: j is assigned the value 5 and then i is incremented to 6.
Console.WriteLine($"i: {i}, j: {j}");  // Outputs "i: 6, j: 5"

i = 5;
j = --i;  // Prefix decrement: i is decremented to 4 and then j is assigned the value 4.
Console.WriteLine($"i: {i}, j: {j}");  // Outputs "i: 4, j: 4"

i = 5;
j = i--;  // Postfix decrement: j is assigned the value 5 and then i is decremented to 4.
Console.WriteLine($"i: {i}, j: {j}");  // Outputs "i: 4, j: 5"
```

## 8. Arithmetic Operators

C# has a set of built-in arithmetic operators that you can use to perform calculations on variables and literals. Some examples include:

C#:

```csharp
int i = 10;
int doubleValue = i * 2;  // doubleValue is now 20
int incrementByFive = i + 5;  // incrementByFive is now 15
int decrementByThree = i - 3;  // decrementByThree is now 7
int dividedByTwo = i / 2;  // dividedByTwo is now 5
int remainder = i % 3;  // remainder is now 1
```

## 9. Console I/O and String Interpolation

In C#, Console.WriteLine() is used to print out text to the console, and Console.ReadLine() is used to read a line of text from the console.

To concatenate strings, C# uses the + operator, but it also supports string interpolation, which is a more readable and convenient way to include variable values in strings.

Here are some examples:

```csharp
string name = "John";
int age = 20;

// Printing out using concatenation
Console.WriteLine("Hello, " + name + ". You are " + age + " years old.");

// Printing out using string interpolation
Console.WriteLine($"Hello, {name}. You are {age} years old.");

// Reading from the console
Console.WriteLine("Please enter your name:");
string inputName = Console.ReadLine();
Console.WriteLine($"Hello, {inputName}!");
```
