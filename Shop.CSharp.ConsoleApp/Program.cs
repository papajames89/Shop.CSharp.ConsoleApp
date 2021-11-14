using System;
using System.Collections.Generic;

namespace Shop.CSharp.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Products> products = new List<Products>();
			Products apple = new Products();
			//apple.Name = "apple";
			//apple.BuyCost = 10;
			//apple.Type = "fruit";
			//apple.Fruit = new Fruits();
			//apple.Drink = new Drinks();
			//apple.Drink.Capacity = 2;
			//apple.Fruit.Weigth = 10;
			//products.Add(apple);
			StartProgram(products);
			PrintBasket(products);
			
			
			
		}



		static void StartProgram(List<Products> products)
		{
			Console.WriteLine("Podaj liczbę produktów do wprowadzenia: ");
			byte numberOfProducts = byte.Parse(Console.ReadLine());
			AddProductsToSell(products, numberOfProducts);
		}
		static void AddProductsToSell(List<Products> products, byte number)
		{
			int i = 1;
			while (i <= number)
			{
				Products product = Products.CreateProduct();
				products.Add(product);
				i++;
			}
		}
		static void PrintBasket(List<Products>products)
		{
			
			foreach (var product in products)
			{
				Console.WriteLine($"Nazwa produktu: {product.Name},\tKoszt zakupu: {product.BuyCost},\tTyp produktu: {product.Type},\tPojemność produktu: {product.Drink?.Capacity ?? 0},\tWaga produktu: {product.Fruit?.Weigth ?? 0}\n");
			}
		}
		

		

		


		

		
		
		
		
		
		
	}


}
