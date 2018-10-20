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
			uint numero, numeros_impares, contador, quadrado;
			numeros_impares = 1;
			quadrado = 1;
			Console.WriteLine("Digite o número para descobrir o quadrado.");
			numero = uint.Parse(Console.ReadLine());
			Console.WriteLine(numeros_impares);
			for (contador = 2; contador <= numero; contador++)
			{
				numeros_impares += 2;
				quadrado += numeros_impares; 
				Console.WriteLine(numeros_impares);
			}
			Console.WriteLine("Quadrado: {0}", quadrado);
			Console.Read();
		}
	}
}
