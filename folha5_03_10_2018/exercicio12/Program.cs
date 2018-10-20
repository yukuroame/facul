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
			double E, contador;
			uint N;
			E = 0;
			Console.WriteLine("Digite o número.");
			N = uint.Parse(Console.ReadLine());
			for (contador = 1; contador <= N; contador++)
			{

				E = E + (1 / contador);
			}
			Console.WriteLine("O valor do E é: {0:0.00}", E);
			Console.Read();
		}
	}
}
