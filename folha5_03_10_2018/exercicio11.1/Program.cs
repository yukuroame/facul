using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11._1
{
	class Program
	{
		static void Main(string[] args)
		{
			uint numero, contador;
			Console.WriteLine("Digite o número!");
			numero = uint.Parse(Console.ReadLine());
			if (numero == 2)
			{
				Console.WriteLine("É primo!");
			}
			else
			{
				for (contador = 2; contador <= numero - 1; contador++)
				{
					if (numero % contador == 0)
					{
						Console.WriteLine("Não é primo!");
						break;
					}
					else
					{
						Console.WriteLine("É primo!");
					}
				}
			}
			Console.Read();
		}
	}
}
