using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
	class Program
	{
		static void Main(string[] args)
		{
			int numero_desejado, npar;
			float c, numero, media, par;
			par = 0;
			numero = 0;
			npar = 0;
			Console.WriteLine("Digite a quantidade de números que deseja.");
			numero_desejado = int.Parse(Console.ReadLine());
			for (c = 1; c <= numero_desejado; c++)
			{
				Console.WriteLine("Digite o número.");
				numero = float.Parse(Console.ReadLine());
				if (numero % 2 == 0)
				{
					npar++;
					par = par + numero;
				}
			}
			media = par / npar;
			Console.Write("A media é: {0}", media);
			Console.Read();
		}
	}
}
