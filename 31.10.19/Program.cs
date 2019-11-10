using System;

namespace _31._10._19
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] names = new string[5];
			names[0] = "Anna";
			names[1] = "Ricahrd";
			names[2] = "John";
			names[3] = "Anna";
			names[4] = "Jack";

			string searchName = "Anna";	
			int counter= 0;
			
					
			foreach (string name in names)
			{
				if(name == searchName)//mingi tingimus peaks olema, et counter hakkaks tööle
				{
                counter++;
				}

			}

			Console.WriteLine($" There are {counter} {searchName} ");

			Console.ReadLine();
		}

	}
}

