using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio9
{
	class Program
	{
		static void Main(string[] args)
		{
			uint n, contador, numeros_impares;
			numeros_impares = 1;
			Console.WriteLine("Digite o número de ímpares que deseja ver.");
			n = uint.Parse(Console.ReadLine());
			for (contador = 1; contador <= n; contador++)
			{
				Console.WriteLine("Números ímpares: {0}", numeros_impares);
				numeros_impares += 2;
			}
			Console.Read();
		}
	}
}
