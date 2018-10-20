using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio13
{
	class Program
	{
		static void Main(string[] args)
		{
			uint mes;
			double aplicacao, divida;
			divida = 10000;
			aplicacao = 1500;
			mes = 1;
			for (; ; )
			{
				divida = divida * 1.025;
				aplicacao = aplicacao * 1.04;
				if (aplicacao >= divida)
					break;
				mes++;

			}
			Console.WriteLine("total d mes: {0}", mes);
			Console.Read();
		}
	}
}
