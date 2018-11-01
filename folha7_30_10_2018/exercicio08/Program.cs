using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio08
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] W = new int[9];
			int[] Y = new int[9];
			int c;
			for (c = 0; c <= 8; c++)
			{
				Console.WriteLine("Digite o {0}º número.", c+1);
				W[c] = int.Parse(Console.ReadLine());
				if (W[c] % 2 == 0)
				{
					Y[c] = W[c] / 2;
				}
				else
				{
					Y[c] = W[c] * 5;
				}
			}
			for (c = 0; c <= 8; c++)
			{
				Console.WriteLine("Vetor Y nº {0}: {1}", c + 1, Y[c]);
			}
			Console.Read();
		}
	}
}
