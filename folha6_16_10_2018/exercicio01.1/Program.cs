using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01._1
{
	class Program
	{
		static void Main(string[] args)
		{
			uint x;
			x = 2;
			while (x <= 100)
			{
				Console.WriteLine(x);
				x += 2;
			}
			Console.Read();
		}
	}
}
