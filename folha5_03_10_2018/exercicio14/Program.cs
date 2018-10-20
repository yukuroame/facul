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
			uint selo3, selo5, x, y;
			float taxa;
			selo3 = 0;
			selo5 = 0;
			Console.WriteLine("Digite a taxa, mínimo 8.");
			taxa = float.Parse(Console.ReadLine());
			if (taxa >= 8)
			{

				if (taxa%5==0)
				{
					for (x = taxa; x >= 0; x -= 5)
					{
						selo5++;
					}
				}
				else if (taxa%5==1)
				{
					for (x = taxa; x >= 0; x -= 5)
					{
						selo5++;
					}
					Console.WriteLine(x);

				}
			}
			else
			{
				Console.WriteLine("Taxa inválida!");
				return;
			}
			Console.Read();
		}
	}
}
