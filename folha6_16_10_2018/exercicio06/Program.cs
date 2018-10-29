using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06
{
	class Program
	{
		static void Main(string[] args)
		{
			int x, y;
			y = 1;
			Console.WriteLine("Digite o número para calcular o fatorial.");
			x = int.Parse(Console.ReadLine());
			y *= x;
			x--;
			while (x >= 1)
			{
				y *= x;
				x--;
			}
			Console.WriteLine("Fatorial do número: {0}", y);
			Console.Read();
		}
	}
}
