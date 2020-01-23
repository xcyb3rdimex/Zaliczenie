using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		
		private static void Loop()
		{
			List<Client> c = new List<Client>();
			bool exit = false;
			while (!exit)
			{

				DisplayMenu();
				int ans;
				int.TryParse(Console.ReadLine(), out ans);
				switch (ans)
				{
					case 1:
						Console.WriteLine("Podaj imie ");
						string imie = Console.ReadLine();
						Console.WriteLine("Podaj nazwisko ");
						string nazwisko = Console.ReadLine();
						Console.WriteLine("Podaj wiek " );
						int wiek;
						int.TryParse(Console.ReadLine(), out wiek);

						Console.WriteLine("Podaj nr buta" );
						int nr_buta;
						int.TryParse(Console.ReadLine(), out nr_buta);
						DateTime pocz = DateTime.Now;
						DateTime koniec = pocz.AddMinutes(2);
						
						c.Add(new Client(imie, nazwisko, wiek, pocz, koniec, nr_buta));
							
						Console.ReadKey();
						Console.Clear();
						break;
					case 2:
						c.ForEach(Console.WriteLine);
						Console.ReadKey();
						Console.Clear();
						break;
					case 3:
						Console.WriteLine("Podaj Nazwisko");
						string search = Console.ReadLine(); ;
						foreach (Client client in c)
						{
							if (client.LastName == search)
							{
								Console.WriteLine (client);
								if (client.EndRental < DateTime.Now)
								{
									client.Cost += client.Cost;
									client.EndRental.AddMinutes(2);
								}
								
							}
							Console.ReadKey();
							Console.Clear();
						}
						break;
					case 4:
						exit = true;
						break;
					default:
						Console.WriteLine("Spróbuj ponownie");
						Console.ReadKey();
						Console.Clear();
						break;
				}
			}
		}
		static void Main(string[] args)
		{
			Loop();
		}

		private static void DisplayMenu()
			{
			Console.WriteLine("********-$ MENU $-********");
			Console.WriteLine("[1] Rent skates");
			Console.WriteLine("[2] See who rides");
			Console.WriteLine("[3] Check how much time you have");
			Console.WriteLine("[4] Exit");
			}
		public static List<Client> GiveSkates(List<Client> list, Client client)
		{
			
			for (int i = 0; i < list.Count; i++)
			{
				if (client.LastName == list[i].LastName)
				{
					list.RemoveAt(i);
				

					return list;
				}

			}
			return list;

		}
		
	}
}
