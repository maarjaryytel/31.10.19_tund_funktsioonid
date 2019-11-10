using System;

namespace meetod
{
	class Program
	{
		static void Main(string[] args)
		{
			string fullName = "Maarja Rüütel "; //nime lõppu panime tühiku
												//vaatame selle sõna pikkust//
			Console.WriteLine($"Full name length before trim: {fullName.Length} ");

			//see trim võtab meilt tühiku ära

			fullName = fullName.Trim().ToLower();
			Console.WriteLine($"Full name length after trim: {fullName.Length} ");
			
			Console.WriteLine($"{fullName[0]}");
			//kui ma tahan nime eraldi nime ja perekonnanime 

			int indexOfSpace = fullName.IndexOf(' ');
			Console.WriteLine($"The position of the space is {indexOfSpace}");

			//loon 2 uut muutujat kuhu salvestan ees ja perenimi
			//substring_ kust ma võtan selle sõna, mida tahan salvestada
			string firstName = fullName.Substring(0, indexOfSpace); 
			string lastName = fullName.Substring(indexOfSpace + 1);//indof space on mul 5
									//mina tahan seda järgmist elementi//
			Console.WriteLine($"name: {firstName}");//saime oma nime kätte

			//kuidas perenime kätte saada, peame ütlema, kust alustame, lõppu pole vaja öelda

			Console.WriteLine($"Last name: {lastName}");

			//see on 1 viis kuidas saame ühest sõnast 2 sõna*/

			//split- lõhkuma
			//paneme parameetrid, mille järgi hakkame sõnu otsima ja salvestame massiivis sisse
			//salvestaks minu nime ja esimesele elemendile paneks minu perekonnanime väärtuse
			string[] personalData = fullName.Split(' ');
			foreach (string value in personalData)
			{
				Console.WriteLine($"Value from personalData: {value}");
			}
			Console.ReadLine();
		}
	}
}
