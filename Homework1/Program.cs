/*
Problem 1: Arrays and Loops
The code should iterate through an array and print out all the even numbers. However, it's not working as expected.
*/


int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        Console.WriteLine(numbers[i]);
    }
}
// Expected output: 
// 2
// 4
// 6
// 8
// 10
