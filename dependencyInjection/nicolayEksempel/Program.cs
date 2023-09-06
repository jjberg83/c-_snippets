// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;

// Microsoft.Extensions.DependencyInjection.ServiceCollection
// vi ser hva vi har tilgang på her, genialt!

var services = new ServiceCollection();
services.AddSingleton<IDataStore, InMemoryStoreV2>();
var provider = services.BuildServiceProvider();
var enMemoryStore = provider.GetRequiredService<IDataStore>();

var enPerson = new Person ("Pippi", "Langstrømpe");
var enStudent = new Student("Bjørn", "Bjørnsen", 666555);
var enStudAss = new StudentAssistant("Kai", "Ovesen", 123, 456);

// var enMemoryStore = new InMemoryStore(); // Kjør første versjon/implementasjon
// var enMemoryStore = new InMemoryStoreV2();  // Kjør andre implementasjon
// kunne også skrevet begge følgende (men den med interfacet er mindre vanlig, kun brukt når man skal legge inn i metode)
// InMemoryStore enMemoryStore = new InMemoryStore(); 
// IDataStore enMemoryStore = new InMemoryStore(); // her som interface type!
// enMemoryStore.Store("Joda"); // siden man ikke legger inn en verdi, vil den bare bli empty, altså ""
StoreTest(enMemoryStore);
Console.WriteLine(enMemoryStore.Get());

PrintPerson(enPerson);
PrintPerson(enStudent);
PrintPerson(enStudAss);
PrintEmployee(enStudAss);
// Legg merke til at man over legger inn en instans av StudentAssistant klassen
// , og det godtas av funksjonen PrintEmployee som krever IEmployee interface som input
// Godtas fordi klassen StudentAssitant implementerer interfacet


public class AddTest
{
    public IDataStore Store { get; }

    public AddTest(IDataStore store)
    {
        Store = store;
    }

    public void Run() 
    {
        Store.Store("En test");
    }
}

void StoreTest(IDataStore store)
{
    store.Store("Litt innhold");
}

void PrintPerson(Person p) 
{
    Console.WriteLine($"{p.FirstName} {p.LastName}.");
}

void PrintEmployee(IEmployee studass)
{
    Console.WriteLine($"{studass.EmployeeID}");
}

public class Person
{
    // auto implemented properties (i bakgrunnen lages get og set metoder)
    public string FirstName { get; set; } 
    public string LastName { get; set; }

    public Person( string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

public class Student : Person
{
    public int StudentID { get; set; }
    public Student(string firstName, string lastName, int studentID) : base(firstName, lastName)
    {
        StudentID = studentID;
    }
}

public class StudentAssistant : Student, IEmployee, IEmployeeV2
{
    public int EmployeeID { get; set; }
    short IEmployeeV2.EmployeeID { get; set; }
    //Legg merke til at man over kan ha en property med samme navn og forskjellig type
    // Men at man må spesifisere at det er snakk om en IEmployeeV2.EmployeeID og ikke bare EmployeeID

    public StudentAssistant(string firstName, string lastName, int studentID, int employeeID) 
        : base(firstName, lastName, studentID)
    {
        EmployeeID = employeeID;
    }
}

public interface IEmployee
{
    int EmployeeID { get; set; }
}

public interface IEmployeeV2
{
    short EmployeeID { get; set; }
}

public interface IDataStore
{
    public void Store(string s);

    public string Get();
}

public class InMemoryStore : IDataStore
{
    private string StoreVar { get; set; } = string.Empty;
    // string.Empty over gjør at man aldri får en string som er null.
    // Dette er jo en reference type, som får null verdier hvis man ikke har gitt den en verdi.
    // string? gjør at denne kan være null
    public string Get()
    {
        return StoreVar;
    }

    public void Store(string s)
    {
        StoreVar = s;
    }
}

public class InMemoryStoreV2 : IDataStore
{
    private string StoreVar { get; set; } = string.Empty;
    public string Get()
    {
        return StoreVar + "Hello you gorgeous";
    }

    public void Store(string s)
    {
        StoreVar = s;
    }
}

/*
public void Store(string s);

public string Get();
*/