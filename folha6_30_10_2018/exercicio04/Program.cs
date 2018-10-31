using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio04
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] A = new int[10];
			int[] B = new int[10];
			int x, y;
			y = 9;
			for (x = 0; x <= 9; x++)
			{
				Console.WriteLine("Digite o {0}º número do vetor A.", x + 1);
				A[x] = int.Parse(Console.ReadLine());
				B[y] = A[x];
				y--;
			}
			for (x = 0; x <= 9; x++)
			{
				Console.WriteLine("Vetor A: {0}", A[x]);
			}
			for (y = 0; y <= 9; y++)
			{
				Console.WriteLine("Vetor B: {0}", B[y]);
			}
			Console.Read();
		}
	}
}
