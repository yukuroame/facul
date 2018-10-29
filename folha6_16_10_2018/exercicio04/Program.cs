using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio04
{
	class Program
	{
		static void Main(string[] args)
		{
			int x, y, z;
			x = 9;
			y = 1;
			while (y <= 10)
			{
				z = x * y;
				Console.WriteLine("{0}x{1}={2}",x, y, z);
				y++;
			}
			Console.Read();
		}
	}
}
