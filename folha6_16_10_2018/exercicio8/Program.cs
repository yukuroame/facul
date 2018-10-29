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
			uint x;
			float soma, y;
			x = 1;
			y = 1;
			soma = 0;
			while (x <= 20)
			{
				soma += (1 / y);
				y *= 2;
				x++;
			}
			Console.WriteLine(soma);
			Console.Read();
		}
	}
}
