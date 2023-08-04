using System;
namespace NonPrimitiveProject
{
	public class Calculator
	{
		public string brand;

		public Calculator(string merke)
		{
			brand = merke;
		}

		public int Gang(int tall1, int tall2)
		{
			return tall1 * tall2;
		}


	}
}

