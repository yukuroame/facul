using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio09
{
	class Program
	{
		static void Main(string[] args)
		{
			uint c = 1;
			float x = 1000, y = 1, z = 0;
			while (c <= 50)
			{
				z += x / y;
				x -= 3;
				y++;
				c++;
			}
			Console.WriteLine(z);
			Console.Read();
		}
	}
}
