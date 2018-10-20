using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11
{
	class Program
	{
		static void Main(string[] args)
		{
			uint numero, contador, verificar;
			verificar = 0;
			Console.WriteLine("Digite o número.");
			numero = uint.Parse(Console.ReadLine());
			for (contador = 1; contador <= numero; contador++)
			{
				if (numero % contador == 0)
				{
					verificar++;
				}
			}
			if (verificar == 2)
			{
				Console.WriteLine("É número primo!");
			}
			else
			{
				Console.WriteLine("Não é primo!");
			}
			Console.Read();
		}
	}
}
