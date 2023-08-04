using System;
namespace NonPrimitiveProject
{
	public class Person
	{
		public string _name;

		public Person(string name)
		{
			_name = name;
		}

		public void Introduce()
		{
			Console.WriteLine($"My name is {_name}");
		}
	}
}

