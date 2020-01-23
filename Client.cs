using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class Client
	{
		public Client()
		{

		}
		public Client(string fn, string ln, int age, DateTime r, DateTime er, int sn)  //konstruktor
		{
			
			_firstName = fn;
			_lastName = ln;
			_age = age;
			_rental = r;
			_endRental = er;
			_shoesNumber = sn;
			_cost = Discounts.Discount(age);
		}
	
		private string _firstName;
		private string _lastName;
		private int _age;
		private DateTime _rental;
		private DateTime _endRental;
		private int _shoesNumber;
		private double _cost;

		public string FirstName { get => _firstName; set => _firstName = value; }
		public string LastName { get => _lastName; set => _lastName = value; }
		public DateTime Rental { get => _rental; set => _rental = value; }
		public int ShoesNumber { get => _shoesNumber; set => _shoesNumber = value; }
		public DateTime EndRental { get => _endRental; set => _endRental = value; }
		
		public double Cost { get => _cost; set => _cost = value; }
		public int Age { get => _age; set => _age = value; }

		public override string ToString()
		{
			return $" Imie : {_firstName} Nazwisko :{_lastName}  { _endRental -DateTime.Now} \n Aktualna należność {_cost}";
		}
	}
}
