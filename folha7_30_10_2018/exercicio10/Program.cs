using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] A = new int[10];
			int c, par, impar;
			par = 0;
			impar = 0;
			for (c = 0; c <= 9; c++)
			{
				Console.WriteLine("Digite o {0}º número.", c+1);
				A[c] = int.Parse(Console.ReadLine());
				if (A[c] % 2 == 0)
				{
					par++;
				}
				else
				{
					impar++;
				}
			}
			Console.WriteLine("O Vetor A tem {0} par(es) e {1} ímpar(es).", par, impar);
			Console.Read();
		}
	}
}
