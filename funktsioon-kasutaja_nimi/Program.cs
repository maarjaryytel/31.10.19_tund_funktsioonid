using System;

namespace funktsioon_kasutaja_nimi
{
	class Program
	{
		static void Main(string[] args)
		{
			//loome funktsiooni
			Console.WriteLine("Enter your first and last name: ");
			string fullName = Console.ReadLine();
			GetArrayFromString(fullName);
			Console.ReadLine();
			
		}

		public static void GetArrayFromString(stringToSplit) //siia hakkab salvestama eesja perenimi
		{
			string[] personalData = stringToSplit(' '); //ta loob selle  personaldata massiiviks, split tagastab massiivi
			Console.WriteLine($"First name: {personalData[0]}"); //siia salvestas eesnime
			Console.WriteLine($"Last name: {personalData[1]}");
		}


	}
}
