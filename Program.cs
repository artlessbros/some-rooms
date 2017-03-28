using System;

namespace SomeRooms
{
	class Program
	{
		private static string Name;

		static void Main(string[] args)
		{
			Console.Write("What's your name?");
			Name = Console.ReadLine();

			Bar();
		}

		private static void Bar()
		{
			Console.Clear();
			Console.WriteLine("Hey {0} you're now in the bar", Name);
			Console.WriteLine("-");
			Console.WriteLine("Where would you like to go?");
			Console.WriteLine("1) The backroom");
			Console.WriteLine("2) Outside");

			Console.Write("Option: ");

			var key = Console.ReadKey();

			switch (key.Key)
			{
				case ConsoleKey.D1:
				case ConsoleKey.NumPad1:
					Backroom();
					break;
				case ConsoleKey.D2:
				case ConsoleKey.NumPad2:
					Outside();
					break;
				default:
					Console.Clear();
					Console.WriteLine("I don't know that room!");
					Console.WriteLine("Go back to the bar..");
					Console.ReadKey(true);
					Bar();
					break;
			}
		}

		private static void Backroom()
		{
			Console.Clear();
			Console.WriteLine("Hey {0} you're now in the backroom", Name);
			Console.WriteLine("-");
			Console.WriteLine("Where would you like to go?");
			Console.WriteLine("1) The bar");

			Console.Write("Option: ");

			var key = Console.ReadKey();

			switch (key.Key)
			{
				case ConsoleKey.D1:
				case ConsoleKey.NumPad1:
					Bar();
					break;
				default:
					Console.Clear();
					Console.WriteLine("I don't know that room!");
					Console.WriteLine("Go back to the backroom..");
					Console.ReadKey(true);
					Backroom();
					break;
			}
		}

		private static void Outside()
		{
			Console.Clear();
			Console.WriteLine("Hey {0} you're now outside", Name);
			Console.WriteLine("-");
			Console.WriteLine("Where would you like to go?");
			Console.WriteLine("1) The bar");

			Console.Write("Option: ");

			var key = Console.ReadKey();

			switch (key.Key)
			{
				case ConsoleKey.D1:
				case ConsoleKey.NumPad1:
					Bar();
					break;
				default:
					Console.Clear();
					Console.WriteLine("I don't know that room!");
					Console.WriteLine("Go back outside..");
					Console.ReadKey(true);
					Outside();
					break;
			}
		}
	}
}