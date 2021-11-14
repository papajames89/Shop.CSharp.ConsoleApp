using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.CSharp.ConsoleApp
{
	public class Drinks : Products
	{
		public float Capacity { get; set; }


		static void GetCapacity(Drinks drink)
		{
			Console.WriteLine("Podaj objętość napoju: ");
			drink.Capacity = float.Parse(Console.ReadLine());
		}
		public static Drinks CreateDrink()
		{
			Drinks drink = new Drinks();
			GetCapacity(drink);
			return drink;
		}
	}
}
