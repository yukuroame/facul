using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1
{
	class Program
	{
		static void Main(string[] args)
		{
			uint selo3, selo5, resto, x, taxa;
			selo3 = 0;
			Console.WriteLine("Digite a taxa, mínimo 8.");
			taxa = uint.Parse(Console.ReadLine());
			if (taxa >= 8)
			{
				selo5 = taxa / 5;
				resto = taxa % 5;
				for (; ; )
				{
					if (resto == 0)
					{
						break;
					}
					else if (resto == 3)
					{
						selo3++;
						break;
					}
					else
					{
						selo5--;
						x = resto + 5;
						selo3 = x / 3;
						resto = x % 3;
					}
				}
				Console.WriteLine("selo de 5 centavos: {0} \nselos de 3 centavos: {1}", selo5, selo3);

			}
			else
			{
				Console.WriteLine("Taxa inválida!");

			}
			Console.Read();
		}
	}
}
