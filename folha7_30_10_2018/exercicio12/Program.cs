using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] A = new int[50];
			int c, x, p;
			x = 0;
			p = 0;
			for (c = 0; c <= 49; c++)
			{
				Console.WriteLine("Digite o {0}º número.", c + 1);
				A[c] = int.Parse(Console.ReadLine());
				if (A[c] >= 0)
				{
					p += A[c];
				}
				else
				{
					x++;
				}
			}
			Console.WriteLine("A soma dos números positivos: {0} \nA quantidade de valores begativos: {1}", p, x);
			Console.Read();
		}
	}
}
