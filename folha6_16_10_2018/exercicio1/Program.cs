using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
	class Program
	{
		static void Main(string[] args)
		{
			uint x;
			x = 1;
			while (x <= 100)
			{
				if (x % 2 == 0)
				{
					Console.WriteLine(x);
				}
				x++;
			}
			Console.Read();
		}
	}
}
