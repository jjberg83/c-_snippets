// C# program to illustrate how
// to create a dictionary
using System;
using System.Collections.Generic;

class GFG
{
    public static void loopThrough2(Dictionary<string, string> theDict) {
        foreach (KeyValuePair<string, string> element in theDict)
        {
            Console.WriteLine($"{element.Key}: {element.Value}");
        }
        Console.WriteLine();
    }
    // Main Method
    static public void Main()
    {

        // Creating a dictionary
        // using Dictionary<TKey,TValue> class
        Dictionary<int, string> My_dict1 =
                    new Dictionary<int, string>();

        // Adding key/value pairs
        // in the Dictionary
        // Using Add() method
        My_dict1.Add(1123, "Welcome");
        My_dict1.Add(1124, "to");
        My_dict1.Add(1125, "GeeksforGeeks");

        foreach (KeyValuePair<int, string> element in My_dict1)
        {
            Console.WriteLine("{0}: {1}", element.Key, element.Value);
        }
        Console.WriteLine();

        // Creating another dictionary
        // using Dictionary<TKey,TValue> class
        // adding key/value pairs without
        // using Add method
        Dictionary<string, string> My_dict2 =
                new Dictionary<string, string>(){
                                {"a.1", "Dog"},
                                {"a.2", "Cat"},
                                {"a.3", "Pig"} };

        loopThrough2(My_dict2);
        My_dict2.Remove("a.2");
        loopThrough2(My_dict2);
    }
}
