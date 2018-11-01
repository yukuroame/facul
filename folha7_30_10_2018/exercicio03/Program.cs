using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03
{
	class Program
	{
		static void Main(string[] args)
		{
			float[] A = new float[9];
			float[] B = new float[9];
			float[] C = new float[9];
			int x;
			for (x = 0; x <= 8; x++)
			{
				Console.WriteLine("Digite o {0}º número do vetor A.", x + 1);
				A[x] = float.Parse(Console.ReadLine());
			}
			for (x = 0; x <= 8; x++)
			{
				Console.WriteLine("Digite o {0}º número do vetor B", x + 1);
				B[x] = float.Parse(Console.ReadLine());
			}
			for (x = 0; x <= 8; x++)
			{
				C[x] = A[x] - B[x];
				Console.WriteLine(C[x]);
			}
			Console.Read();
		}
	}
}
