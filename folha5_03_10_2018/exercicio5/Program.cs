using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
	class Program
	{
		static void Main(string[] args)
		{
			int numero_desejado, antecessor, sucessor, quadrado, contador, numero;
			Console.WriteLine("Digite o valor de números que deseja digitar a seguir.");
			numero_desejado = int.Parse(Console.ReadLine());

			for (contador = 1; contador <= numero_desejado; contador++)
			{
				Console.WriteLine("Digite o número.");
				numero = int.Parse(Console.ReadLine());
				antecessor = numero - 1;
				sucessor = numero + 1;
				quadrado = numero * numero;
				Console.WriteLine("número: {0} \nantecessor: {1} \nsucessor: {2} \nquadrado: {3}", numero, antecessor, sucessor, quadrado);
			}

			Console.Read();
		}
	}
}
