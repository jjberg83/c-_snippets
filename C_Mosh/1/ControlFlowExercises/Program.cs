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

        //Console.WriteLine("Enter a number between 1 and 10:");
        //string theReply = Console.ReadLine();
        //int theNumber;

        //bool validering = int.TryParse(theReply, out theNumber);

        ////if (theNumber >= 1 && theNumber <= 10)
        ////    Console.WriteLine("Valid");
        ////else
        ////    Console.WriteLine("Invalid");

        //// Switch kan også brukes med range
        //// https://stackoverflow.com/questions/20147879/switch-case-can-i-use-a-range-instead-of-a-one-number

        //switch (theNumber)
        //{
        //    case int n when (n >= 1 && n <= 10):
        //        Console.WriteLine("Gyldig");
        //        break;
        //    default:
        //        Console.WriteLine("Ugyldig");
        //        break;
        //}

        // 2 - Write a program which takes two numbers from the
        // console and displays the maximum of the two.

        //Console.WriteLine("Enter first number:");
        //string num1Str = Console.ReadLine();
        //Console.WriteLine("Enter second number:");
        //string num2Str = Console.ReadLine();
        //int num1, num2;
        //bool num1Valid = int.TryParse(num1Str, out num1);
        //bool num2Valid = int.TryParse(num2Str, out num2);
        //if (num1Valid && num2Valid)
        //{
        //    int maxNum = Math.Max(num1, num2);
        //    Console.WriteLine($"Det største tallet av de to er {maxNum}");
        //}
        //else
        //    Console.WriteLine("Input var ikke gyldig.");


    }
}

