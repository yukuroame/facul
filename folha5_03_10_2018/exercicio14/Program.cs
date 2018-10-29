using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio14
{
	class Program
	{
		static void Main(string[] args)
		{
			uint selo3, selo5, x, taxa;
			selo3 = 0;
			selo5 = 0;
			Console.WriteLine("Digite a taxa, mínimo 8.");
			taxa = uint.Parse(Console.ReadLine());
			if (taxa >= 8)
			{
				if (taxa % 5 == 0)
				{
					selo5 = taxa / 5;
				}
				else
				{
					for (x = taxa; x >= 5; x -= 5)
					{
						selo5++;
					}
					if (x == 1)
					{
						selo5--;
						x += 5;
						selo3 = x / 3;
					}
					else if (x == 2)
					{
						selo5 -= 2;
						x += 10;
						selo3 = x / 3;
					}
					else if (x == 3)
					{
						selo3 = x / 3;
					}
					else if (x == 4)
					{
						selo5--;
						x += 5;
						selo3 = x / 3;
					}
				}
				Console.WriteLine("Selos de 5 centavos: {0} \nselos de 3 centavos: {1}", selo5, selo3);
			}
			else
			{
				Console.WriteLine("Taxa inválida!");
			}
			Console.Read();
		}
	}
}
