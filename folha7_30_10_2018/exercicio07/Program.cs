using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio07
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] X = new int[12];
			int[] Z = new int[12];
			int c;
			for (c = 0; c <= 11; c++)
			{
				Console.WriteLine("Digite o {0}º número.", c+1);
				X[c] = int.Parse(Console.ReadLine());
				if (X[c] % 2 != 0)
				{
					Z[c] = X[c] * 2;
				}
				else
				{
					Z[c] = X[c];
				}
			}
			for (c = 0; c <= 11; c++)
			{
				Console.WriteLine("Vetor Z: {0}", Z[c]);
			}
			Console.Read();
		}
	}
}
