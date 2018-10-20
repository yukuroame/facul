using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
	class Program
	{
		static void Main(string[] args)
		{
			int contador;
			float numero, maior, menor;
			Console.WriteLine("Digite um valor.");
			numero = float.Parse(Console.ReadLine());
			maior = numero;
			menor = numero;
			for (contador = 1; contador <= 49; contador++)
			{
				Console.WriteLine("Digite um valor.");
				numero = float.Parse(Console.ReadLine());
				if (numero > maior)
				{
					maior = numero;
				}
				else if (numero < menor)
				{
					menor = numero;
				}
			}
			Console.WriteLine("Maior número digitado: {0}\nMenor número digitado: {1}", maior, menor);
			Console.Read();
		}
	}
}
