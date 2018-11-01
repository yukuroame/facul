using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] A = new int[10];
			int c, impar;
			impar = 0;
			for (c = 0; c <= 9; c++)
			{
				Console.WriteLine("Digite o {0}º número.", c+1);
				A[c] = int.Parse(Console.ReadLine());
				if (A[c] % 2 != 0)
				{
					impar++;
				}
			}
			Console.WriteLine("Quantidade de ímpar(es): {0} \nPorcentagem: {1}%", impar, impar*10);
			Console.Read();
		}
	}
}
