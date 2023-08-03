/*
The code should check an array of numbers and print an appropriate message for each number: whether it is positive, negative, or zero. However, the code isn't working as expected.
*/

int[] numbers = new int[5];
numbers[0] = -1;
numbers[1] = -2;
numbers[2] = 0;
numbers[3] = 4;
numbers[4] = -5;


foreach (int number in numbers)
{
    if (number > 0)
    {
        Console.WriteLine($"Number {number} is positive");
    }
    else if (number < 0)
    {
        Console.WriteLine($"Number {number} is negative");
    }
    else
    {
        Console.WriteLine($"Number {number} is zero");
    }
}
/* 
Expected output: 
Number -1 is negative
Number -2 is negative
Number 0 is zero
Number 4 is positive
Number -5 is negative
*/