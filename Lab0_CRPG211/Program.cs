namespace Lab0_CRPG211;

/*
Open the Visual Studio IDE.
    Create a new C# Console App project.
    Open the Program.cs file.
    Prompt the user to enter the low number.
    Store the low number as an int variable.
    Prompt the user to enter the high number.
    Store the high number as an int variable.
    Calculate and print out the difference between the low and high variables.
    Task 2: Looping and Input Validation
Write a loop that keeps iterating until the user enters a positive low number.
    Write a loop that keeps iterating until the enters a high number greater than the low number.
    Task 3: Using Arrays and File I/O
Create an array variable that holds every number between low and high.
    Create a new file called "numbers.txt".
Write each number in the array to the file in reverse order (largest to smallest).
Additional Tasks
Use methods get and validate the users input.
Read the numbers back from the file and print out the sum of the numbers.
Use a List instead of an array variable to store the numbers.
Use the double data type instead of the int data type.
Print out the prime numbers between low and high.
Write a method that takes in a number and returns true if it is a prime number.
You may need to use the modulus operator.*/

class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter the low number: ");
        int lowNum = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the high number: ");
        int highNum = int.Parse(Console.ReadLine());
        
        Console.WriteLine(highNum - lowNum);
        
        
    }
}