using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class Discounts :Rental_office
	{
		public static double Discount(int age)
		{
			double result;
			if (age <= 6)
			{
				result = 0;
				Console.WriteLine("Należność " + result);
				return result;
			}

			else if (age <=18)
			{
				result = 6;
				Console.WriteLine("Należność " + result);
				return result;

			}
			else if (age >= 60)
			{

				result = 9;
				Console.WriteLine("Należność " + result);
				return result;
			}
			else
				result = 12;
			Console.WriteLine("Należność " + result);
			return Rental;
		}
		
	}
}
