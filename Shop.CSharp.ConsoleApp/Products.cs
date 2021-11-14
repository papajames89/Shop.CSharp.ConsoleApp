using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.CSharp.ConsoleApp
{
	public class Products
	{
		public string Name { get; set; }
		public decimal BuyCost { get; set; }
		public string Type { get; set; }
		public Fruits Fruit { get; set; }
		public Drinks Drink { get; set; }



		public static Products CreateProduct()
		{
			Products product = new Products();
			GetName(product);
			GetBuyCost(product);
			GetType(product);
			GetSpecificsOfProduct(product);

			return product;
		}
		static void GetName(Products product)
		{
			Console.WriteLine("Podaj nazwe produktu: ");
			product.Name = Console.ReadLine();
		}
		static void GetBuyCost(Products product)
		{
			Console.WriteLine("Podaj cene zakupu produktu: ");
			product.BuyCost = decimal.Parse(Console.ReadLine());
		}

		static void GetType(Products product)
		{
			bool loop = true;
			while (loop)
			{
				Console.WriteLine("Wybierz typ produktu drink/fruit : ");
				string answer = Console.ReadLine();
				if (answer == "fruit")
				{
					product.Type = answer;
					loop = false;
				}
				else if (answer == "drink")
				{
					product.Type = answer;
					loop = false;
				}
			}
		}

		static void GetSpecificsOfProduct(Products product)
		{
			if (product.Type == "drink")
			{
				product.Drink = Drinks.CreateDrink();
			}
			else if (product.Type == "fruit")
			{
				product.Fruit = Fruits.CreateFruit();
			}
		}
	}


	

	


}
