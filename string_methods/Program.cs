using System;

namespace string_methods
{
	class Program
	{
		static void Main(string[] args)
		{
			//kuidas saab ühest sõnast teha massiivi
			//4 meetodit:
			//Trim()- ainult tühikuid trimmib ära, tühikuid ei salvestata andmebaasi
			//indexOf()
			//Substring()
			//Split()

			string fullName = "Maarja Rüütel "; //nime lõppu panime tühiku
												//vaatame selle sÕna pikkust//
			Console.WriteLine($"Full name length before trim: {fullName.Length} ");

			//see string võtab meilt tühiku ära

			fullName = fullName.Trim().ToLower();
			Console.WriteLine($"Full name length after trim: {fullName.Length} ");
			Console.ReadLine();

			//kui me ei taha et tühikuid andmebaasi ei salvestaks, siis me kasutame TRIM. Kui 
			//tahame muutujat salvestama, peame muutuja uuesti määrama//

		}
	}
}
