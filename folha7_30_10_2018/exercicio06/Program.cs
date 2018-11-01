using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] nomes = new string[20];
			int x;
			string nome;
			for (x = 0; x <= 19; x++)
			{
				Console.WriteLine("Digite o {0}º nome", x + 1);
				nomes[x] = Console.ReadLine();
			}
			Console.WriteLine("Digite um nome para pesquisar.");
			nome = Console.ReadLine();
			for (x = 0; x <= 19; x++)
			{
				if (nome == nomes[x])
				{
					Console.WriteLine("1 - O nome etá cadastrado no vetor.");
					break;
				}
			}
			if (nome != nomes[x])
			{
				Console.WriteLine("2 - O nome NÃO está cadastrado no vetor.");
			}
			Console.Read();
		}
	}
}
