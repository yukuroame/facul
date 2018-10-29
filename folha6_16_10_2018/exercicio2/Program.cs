using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
	class Program
	{
		static void Main(string[] args)
		{
			int x;
			x = 99;
			while (x >= 1)
			{
				Console.WriteLine(x);
				x -= 2;
			}
			Console.Read();
		}
	}
}
