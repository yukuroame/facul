using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] A = new char[8];
			char[] B = new char[5];
			char[] C = new char[13];
			int x;
			for (x = 0; x <= 7; x++)
			{
				Console.WriteLine("Digite o {0}º caractere.", x + 1);

			}
			for (x = 0; x <= 4; x++)
			{
				Console.WriteLine("Digite o {0}º caractere.", x + 1);
			}
			for (x = 0; x <= 12; x++)

				Console.Read();
		}
	}
}
