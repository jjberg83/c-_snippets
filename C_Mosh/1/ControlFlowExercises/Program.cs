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

        // 3- Write a program and ask the user to enter the
        // width and height of an image. Then tell if the
        // image is landscape or portrait.

        //Console.WriteLine("Enter width of image:");
        //var widthStr = Console.ReadLine();
        //float width;
        //bool widthValider = float.TryParse(widthStr, out width);
        //Console.WriteLine("Enter height of image:");
        //var heightStr = Console.ReadLine();
        //float height;
        //bool heightValider = float.TryParse(heightStr, out height);
        //bool landscape = (width > height) ? true : false;
        //if (landscape)
        //    Console.WriteLine("The image is a \"landscape\"");
        //else
        //    Console.WriteLine("The image is a \"portrait\"");

        // 4- Your job is to write a program for a speed camera.
        // For simplicity, ignore the details such as camera,
        // sensors, etc and focus purely on the logic.
        // Write a program that asks the user to enter
        // the speed limit. Once set, the program asks for the
        // speed of a car. If the user enters a value less than
        // the speed limit, program should display Ok on the
        // console. If the value is above the speed limit,
        // the program should calculate the number of demerit
        // points. For every 5km/hr above the speed limit,
        // 1 demerit points should be incurred and displayed
        // on the console. If the number of demerit points
        // is above 12, the program should display
        // License Suspended.

        Console.WriteLine("Enter speed limit:");
        var speedLimitStr = Console.ReadLine();
        Console.WriteLine("Enter actual car speed:");
        var carSpeedStr = Console.ReadLine();
        float speedLimit, carSpeed;
        bool speedLimitValidate = float.TryParse(speedLimitStr, out speedLimit);
        bool carSpeedValidate = float.TryParse(carSpeedStr, out carSpeed);
        

    }
}

