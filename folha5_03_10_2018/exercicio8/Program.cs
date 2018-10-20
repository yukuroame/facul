using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio8
{
	class Program
	{
		static void Main(string[] args)
		{
			uint n1, n2, divi, contador;
			Console.WriteLine("Digite o primeiro número.");
			n1 = uint.Parse(Console.ReadLine());
			Console.WriteLine("Digite o segundo número.");
			n2 = uint.Parse(Console.ReadLine());
			Console.WriteLine("Digite o divisor.");
			divi = uint.Parse(Console.ReadLine());
			if (divi == 0) 
			{
				Console.WriteLine("Equação inválida!");
			}
			else if (n1 < n2)
			{
				for (contador = n1 + 1; contador <= n2 -1; contador++)
				{
					if (contador % divi == 0)
					{
						Console.WriteLine("Números existentes entre n1 e n2 e divisíveis por divisor: {0}", contador);
					}
				}
			}
			else if (n1 > n2)
			{
				for (contador = n2 + 1; contador <= n1 - 1; contador++)
				{
					if (contador % divi == 0)
					{
						Console.WriteLine("Números existentes entre n1 e n2 e divisíveis por divisor: {0}", contador);
					}
				}
			}
			else
			{
				Console.WriteLine("Zoeira tem limites, por favor né!");
			}
			Console.Read();
		}
	}
}
