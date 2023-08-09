using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ControlFlowExercises;
class Program
{
    static void Main(string[] args)
    {
        //1 - Write a program and ask the user to
        //    enter a number. The number should be
        //    between 1 to 10.If the user enters a
        //    valid number, display "Valid" on the
        //    console.Otherwise, display "Invalid".
        //    (This logic is used a lot in applications
        //    where values entered into input boxes
        //    need to be validated.)

        Console.WriteLine("Enter a number between 1 and 10:");
        string theReply = Console.ReadLine();
        int theNumber;

        bool validering = int.TryParse(theReply, out theNumber);

        //if (theNumber >= 1 && theNumber <= 10)
        //    Console.WriteLine("Valid");
        //else
        //    Console.WriteLine("Invalid");

        // Switch kan også brukes med range
        // https://stackoverflow.com/questions/20147879/switch-case-can-i-use-a-range-instead-of-a-one-number

        switch (theNumber)
        {
            case int n when (n >= 1 && n <= 10):
                Console.WriteLine("Gyldig");
                break;
            default:
                Console.WriteLine("Ugyldig");
                break;
        }

    }
}

