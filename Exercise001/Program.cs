/* Write a program that asks the user to enter a number between 1 and 10.
 * If the number is valid, print Valid to the console, otherwise print Invalid. */

Console.WriteLine("--------------------------------------------------------------------");
Console.WriteLine("---------------------------Number Validation------------------------");
Console.WriteLine("--------------------------------------------------------------------");
Console.WriteLine();
Console.Write("Please enter a number between 1 & 10: ");
int userInput = Convert.ToInt32(Console.ReadLine());

if (userInput >= 1 && userInput <= 10)
    Console.WriteLine("Valid");
else Console.WriteLine("Invalid");