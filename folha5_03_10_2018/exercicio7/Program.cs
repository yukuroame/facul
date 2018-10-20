using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7
{
	class Program
	{
		static void Main(string[] args)
		{
			uint quantidade_divisor, divisor, numero;
			quantidade_divisor = 0;
			Console.WriteLine("Digite a o numero.");
			numero = uint.Parse(Console.ReadLine());
			for (divisor = 1; divisor <= numero; divisor++)
			{
				if (numero % divisor == 0)
				{
					quantidade_divisor++;
					Console.WriteLine("divisor: {0}", divisor);
				}
			}
			Console.WriteLine("Quantidade de divisores do número: {0}", quantidade_divisor);
			Console.Read();
		}
	}
}
