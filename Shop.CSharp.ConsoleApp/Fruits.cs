using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.CSharp.ConsoleApp
{
	public class Fruits : Products
	{
		public float Weigth { get; set; }

		public static Fruits CreateFruit()
		{
			Fruits fruit = new Fruits();
			GetWeigth(fruit);
			return fruit;
		}

		static void GetWeigth(Fruits fruit)
		{
			Console.WriteLine("Podaj wagę towaru: ");
			fruit.Weigth = float.Parse(Console.ReadLine());
		}
	}
}
