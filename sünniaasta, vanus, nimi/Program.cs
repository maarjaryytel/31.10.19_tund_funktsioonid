using System;

namespace sünniaasta__vanus__nimi
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter your first name, last name; year of birth: ");
			string userData = Console.ReadLine();
			GetUserData(userData);
			Console.ReadLine();
		}
		public static void GetUserData(string userData)
		{
			string[] userDataList = userData.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
			Console.WriteLine($"First name: {userDataList[0]}");
			Console.WriteLine($"Last name: {userDataList[1]}");
			Console.WriteLine($"Age: {2019- int.Parse(userDataList[2])}");
		}
		
		
	}
}
