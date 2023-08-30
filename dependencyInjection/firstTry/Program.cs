// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;


// Youtube video finnes her
// https://www.youtube.com/watch?v=tTJetZj3vg0

/* 1
Hver gang person skapes ønsker vi å skrive en 
kjapp log message til konsollen. Følgende er lite scalable
måte å skrive det på (når noe endres i logger nedenfor, må dette
også endres i alle referansene)
*/


// Person jjberg = new Person("Jørund");
// class Person
// {
//     public Person(string name)
//     {
//         var logger = new Logger(); // her "Newer vi up" klassen Logger, inni klassen Person
//         logger.Log($"{name} was created");
//         Name = name;
//     }

//     public string Name { get; set; }
// }

// public class Logger
// {
//     public void Log(string message)
//     {
//         Console.WriteLine(message);
//     }
// }

/*
2 Samme som over, med bruk av dependency injection
*/


Person secondOne = new Person("Jørund", new Logger()); // Jeg newer up Logger klassen her i stedet
// eventuelt kunne jeg gjort...
// var logger = new Logger();
// Person secondOne = new Person("Jørund", logger); // Jeg newer up Logger klassen inni her i stedet

/*
Nå kan "caller code" bestemme hvilken implementasjon (av ....) den vil bruke
Slik jeg forstår det kunne man ha skapt en thirdOne, som bruker en variant av Logger
som printer til et alert vindu i en browser i stedet. 
*/


class Person
{
    public Person(string name, Logger logger)
    {
        Name = name;
        logger.Log($"{name} ble skapt.");
    }

    public string Name {get; set;}
}

public class Logger 
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}


/*
3 - Tre forskjellige injection fremgangsmåter (constructor, )
*/

// /*
// 3a - Constructor injection
// */

// var bennyBoy = new PersonFactory().GetPerson("Benjamin");
// public class PersonFactory
// {
//     public Person GetPerson(string name) 
//     {
//         var logger = new Logger();
//         return new Person(name, logger); // her er logger parameteren en dependency
//     }
// }
// public class Person 
// {
//     public Person(string name, Logger logger) // her er logger parameteren en dependency
//     {
//         Name = name;
//         logger.Log($"{name} was created");
//     }

//     public string Name{get;set;}
// }

// public class Logger 
// {
//     public void Log(string message)
//     {
//         Console.WriteLine(message);
//     }
// }


/*
3b - Method injection
*/

// var noen = new PersonFactory().GetPerson("Noen");
// public class PersonFactory
// {
//     public Person GetPerson(string name) 
//     {
//         var logger = new Logger();
//         var person = new Person(name);
//         person.DoComplexThings(logger); // her er logger parameteren en dependency inni en metode
//         return person; 
//     }
// }
// public class Person 
// {
//     public Person(string name) 
//     {
//         Name = name;
//     }

//     public void DoComplexThings(Logger logger) 
//     {
//         logger.Log("Very deep, complext stuff going on here");
//     }

//     public string Name{get;set;}
// }

// public class Logger 
// {
//     public void Log(string message)
//     {
//         Console.WriteLine(message);
//     }
// }


/*
3b - Setter injection (FÅR IKKE DENNE TIL Å FUNKE)
*/

// var andre = new PersonFactory().GetPerson("Andre");
// public class PersonFactory
// {
//     public Person GetPerson(string name) 
//     {
//         var logger = new Logger();
//         var Name = name
//         var person = new Person
//         {
//             Name = Name,
//             Logger = logger
//         };
//         return person; 
//     }
// }
// public class Person 
// {
//     public Person(string name,Logger logger) 
//     {
//         Name = name;
//         Logger = logger;
//     }

//     public string Name{get;set;}
//     public Logger Logger {get;set;}
// }

// public class Logger 
// {
//     public void Log(string message)
//     {
//         Console.WriteLine(message);
//     }
// }