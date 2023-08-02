using System;

namespace MyNamespace
{
    class Program
    {
        class MyClass 
        {
            public static int Count = 0;
            private string _forNavn;

            public MyClass(string firstName)
            {
                _forNavn = firstName;
            }

            public string ForNavn
            {
                get => _forNavn;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Count verdien er {MyClass.Count}");
            MyClass person1 = new MyClass("Jørund");
            MyClass person2 = new MyClass("Lori");
            Console.WriteLine($"Navnet til person1 er {person1.ForNavn}");
            Console.WriteLine($"Navnet til person2 er {person2.ForNavn}");
            Console.WriteLine($"Count verdien er fortsatt {MyClass.Count}, men dette kan ikke nås via instansene person1/person2.");
            MyClass.Count = 100;
            Console.WriteLine($"Count verdien er nå {MyClass.Count}, men dette kan ikke nås via instansen instansene person1/person2.");
        }
    }
}

// public Acct(string firstname, string lastname, decimal initialbalance, int withdrawalcounter = 0)
// {
//     _firstname = firstname;
//     _lastname = lastname;
//     Balance = initialbalance;
//     WithdrawalCounter = withdrawalcounter;
// }

// public string FirstName
// {
//     get => _firstname;
// }