using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1 = 0; int num2 = 0; int num3 = 0;
			Console.WriteLine("Skriv in första numret, tryck sedan Enter");
			num1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Skriv in andra numret, tryck sedan Enter");
			num2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Välj din första operator:");
			Console.WriteLine("\ta - Addition");
			Console.WriteLine("\ts - Subtraktion");
			Console.WriteLine("\tm - Multiplikation");
			Console.WriteLine("\td - Division");
			Console.Write("Ditt val?"); 

			switch (Console.ReadLine())
			{
				case "a":
					Console.WriteLine($"Resultatet: {num1} + {num2}  = " + (num1 + num2));
					break;
				case "s":
					Console.WriteLine($"Resultatet: {num1} - {num2}  = " + (num1 - num2));
					break;
				case "m":
					Console.WriteLine($"Resultatet: {num1} * {num2}  = " + (num1 * num2));
					break;
				case "d":
					Console.WriteLine($"Resultatet: {num1} / {num2}  = " + (num1 / num2));
					break;
			}

		
		}
	}
}
