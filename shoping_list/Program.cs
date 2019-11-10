using System;

namespace shoping_list
{
	class Program
	{
		static void Main(string[] args)
		{
			//kasutaja kirjutab mulle shopingu nimekirja

			Console.WriteLine("enter the list of supplies separated by comma: ");

			string userList = Console.ReadLine();
			//me ei tea palju asju ta meile annab
			//tahan luua nendest asjadest listi
			//mul on vaja ka nt hind juurde panna, 
			//tahan kuvada tulbana

			string[] shoppingList = userList.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

			//see stringsplitoptions.remove- võtab mul tühiku ära, st item kahe 2 on tühi element (tühik)
			//kui kasutaja kirju meile, milk, cheese- siis seal on koma ja tühik
			//ma tahan seda massiiivi kuvada ja kirjutada item 1, item 2- selle pärast ma 
			//kasutan seda for loopi

			for (int i = 0; i < shoppingList.Length; i++)
			{
				Console.WriteLine($"Item {i + 1}: {shoppingList[i]}");
			}
			Console.ReadLine();
		}
	}
}
