using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
	class Program
	{
		static void Main(string[] args)
		{
			uint numero, contador, fatorial;
			fatorial = 1;
			Console.WriteLine("Digite um número para fazer fatorial.");
			numero = uint.Parse(Console.ReadLine());
			for (contador = numero - 1; contador >= 1; contador--)
			{
				fatorial *= numero;
				numero--;
			}
			Console.WriteLine("Fatorial do número: {0}", fatorial);
			Console.Read();
		}
	}
}
