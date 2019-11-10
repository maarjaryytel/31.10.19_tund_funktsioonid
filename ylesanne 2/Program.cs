using System;

namespace ylesanne_2
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
			//int counter = 0;
			CountNames(names, searchName);

			/*foreach (string name in names)
			{
				if (name == searchName)//mingi tingimus peaks olema, et counter hakkaks tööle
				{
					counter++;
				}

			}

			Console.WriteLine($" There are {counter} {searchName} ");

			Console.ReadLine();
		}*/
		}
		public static void CountNames(string[] searchArray, string SearchWord)

			{ 
			int counter = 0; //see counter ei ole see sama mis üleval, me ei ole seda veel välja kutsunud

		
				foreach (string word in searchArray) //kõik need muutujad, mida loon funtsiooni sees, need kustustatakse
													 //mälust, kui tingimus lõpetab oma töö
				{
					if (word == SearchWord)
					{
						counter++;
					}

				}
			Console.WriteLine($" There are {counter} {SearchWord} in the array.");
			}

		}
	}

}
	
