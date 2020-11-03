using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
	class Operator
	{
		public static double sum (string op, string op2, int num1, int num2, int num3)
		{
			double total = 0;
			if (op == "+")
			{
				if (op2 == "+")
				{
					total = num1 + num2 + num3;
				}

				else if (op2 == "-")
				{
					total = num1 + num2 - num3;
				}

				else if (op2 == "*")
				{
					total = num1 + num2 * num3;
				}

				else if (op2 == "/")
				{
					total = num1 + num2 / num3;
				}
			}

			if (op == "-")
			{
				if (op2 == "+")
				{
					total = num1 - num2 + num3;
				}

				else if (op2 == "-")
				{
					total = num1 - num2 - num3;
				}

				else if (op2 == "*")
				{
					total = num1 - num2 * num3;
				}

				else if (op2 == "/")
				{
					total = num1 - num2 / num3;
				}
			}

			if (op == "*")
			{
				if (op2 == "+")
				{
					total = num1 * num2 + num3;
				}

				else if (op2 == "-")
				{
					total = num1 * num2 - num3;
				}

				else if (op2 == "*")
				{
					total = num1 * num2 * num3;
				}

				else if (op2 == "/")
				{
					total = num1 * num2 / num3;
				}
			}

			if (op == "/")
			{
				if (op2 == "+")
				{
					total = num1 / num2 + num3;
				}

				else if (op2 == "-")
				{
					total = num1 / num2 - num3;
				}

				else if (op2 == "*")
				{
					total = num1 / num2 * num3;
				}

				else if (op2 == "/")
				{
					total = num1 / num2 / num3;
				}
			}

			return total;
		}

		
	}
}
