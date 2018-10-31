using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] A = new int[8];
			int[] B = new int[8];
			int cont;
			for (cont = 0; cont <= 7; cont++)
			{
				Console.WriteLine("Digite o {0}º número.", cont + 1);
				A[cont] = int.Parse(Console.ReadLine());
			}
			for (cont = 0; cont <= 7; cont++)
			{
				B[cont] = A[cont] * 3;
				Console.WriteLine(B[cont]);
			}
			Console.Read();
		}
	}
}
