using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Equation
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Skriv in första operatorn : + - * / ");
			string op = Console.ReadLine();

			Console.WriteLine("Skriv in andra operatorn : + - * / ");
			string op2 = Console.ReadLine();

			Console.WriteLine("Skriv in första numret, tryck sedan Enter");
			int num1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Skriv in andra numret, tryck sedan Enter");
			int num2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Skriv in tredje numret, tryck sedan Enter");
			int num3 = Convert.ToInt32(Console.ReadLine());

			double total = Operator.sum(op,op2,num1,num2,num3);

			Console.WriteLine(num1 + op + num2 + op2 + num3 + "=" + total);

		}
	}
}
