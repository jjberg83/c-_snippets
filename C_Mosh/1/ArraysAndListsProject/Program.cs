using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArraysAndListsProject;

class Program
{
    static void Main(string[] args)
    {
        ////////////////////
        ///  Arrays video
        ////////////////////
        ///

        // rectangular array
        //var matrix = new int[3, 5]; // altså 3 rows, 5 columns
        //var matrix = new int[3, 5]
        //{
        //    {1,2,3,4,5 },
        //    {6,7,8,9,10 },
        //    {11,12,13,14,15 }
        //};
        //var element = matrix[0,0];
        //Console.WriteLine(element);

        // jagged array
        //var matrix = new int[3][];
        //matrix[0] = new int[3] {1,2,3}; // rad 1 skal ha array med 3 elementer
        //matrix[1] = new int[5] {4,5,6,7,8}; // rad 2 skal ha array med 5 elementer
        //matrix[0] = new int[4] {9,10,11,12}; // rad 3 skal ha array med 4 elementer
        //Console.WriteLine($"{matrix[1][2]}");

        ////////////////////
        ///  Demo:Arrays video
        ////////////////////
        ///

        //int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };
        //var numbers = new[] { 3, 7, 9, 2, 14, 6, 9 };
        ////Console.WriteLine($"Lengde numbers: {numbers.Length}");
        ////Console.WriteLine($"9 kommer første gang på indeks {Array.IndexOf(numbers, 9)}");
        //Array.Clear(numbers, 0, 2);
        //foreach (var tall in numbers)
        //    Console.WriteLine(tall);

        //// copy, syntaks er Array.Copy(src,dst,numberOfElements)
        //var anotherArr = new int[3];
        //Array.Copy(numbers, anotherArr, 3);
        //foreach(var tall in anotherArr)
        //    Console.WriteLine(tall);

        //Console.WriteLine();
        //// Array.Sort
        //Array.Sort(numbers);
        //foreach(var tall in numbers)
        //    Console.WriteLine(tall);

        ////////////////////
        ///  Lists video
        ////////////////////
        ///

        //var numbers = new List<int>();
        //var navn = new List<string> { "stian", "marit", "benjamin", "jørund" };
        //foreach(var fornavn in navn)
        //    Console.WriteLine(fornavn);

        ////////////////////
        ///  Lists Demo video
        ////////////////////
        ///

        //var numbers = new List<int> { 1, 2, 3, 4 };
        //numbers.Add(1);
        //numbers.AddRange(new int[3] { 5, 6, 7 });
        //foreach(var number in numbers)
        //    Console.WriteLine(number);
        //Console.WriteLine();
        //Console.WriteLine("Index of 1:" + numbers.IndexOf(1));
        //Console.WriteLine("Last Index of 1:" + numbers.LastIndexOf(1));
        //Console.WriteLine("Antall elementer: "+ numbers.Count);

        //numbers.Remove(1);
        //foreach (var number in numbers)
        //    Console.WriteLine(number);

        //foreach(var number in numbers)
        //{
        //    if (number == 1)
        //        numbers.Remove(number);
        //}

        //for (var i = 0; i < numbers.Count; i++)
        //{
        //    if (numbers[i]==1)
        //        numbers.Remove(numbers[i]);
        //}
        //foreach (var number in numbers)
        //    Console.WriteLine(number);

        //numbers.Clear();
        //Console.WriteLine("Antall elementer: "+ numbers.Count);

    }
}

