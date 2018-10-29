using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio15
{
	class Program
	{
		static void Main(string[] args)
		{
			uint n1, n2, x, cont, r;
			Console.WriteLine("Digite um número.");
			n1 = uint.Parse(Console.ReadLine());
			Console.WriteLine("Digite mais um número.");
			n2 = uint.Parse(Console.ReadLine());
			Console.WriteLine("Digite quantas vezes você quer ver rodar.");
			x = uint.Parse(Console.ReadLine());
			for (cont = 1; cont <= x; cont++)
			{
				r = n1 + n2;
				Console.WriteLine(r);
				n1 = n2;
				n2 = r;
			}
			Console.Read();
		}
	}
}
