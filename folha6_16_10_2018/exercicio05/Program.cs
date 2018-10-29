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
			string nome, op;
			float peso, altura, imc;
			do
			{
				Console.WriteLine("nome:");
				nome = Console.ReadLine();
				Console.WriteLine("peso:");
				peso = float.Parse(Console.ReadLine());
				Console.WriteLine("altura:");
				altura = float.Parse(Console.ReadLine());
				imc = peso / (altura * altura);
				if (imc < 20)
				{
					Console.WriteLine("Abaixo do peso.");
				}
				else if (imc >= 20 && imc <= 25)
				{
					Console.WriteLine("Peso normal.");
				}
				else if (imc >= 26 && imc <= 30)
				{
					Console.WriteLine("Acima do peso.");
				}
				else if (imc >= 31 && imc <= 35)
				{
					Console.WriteLine("Obesidade.");
				}
				else
				{
					Console.WriteLine("Obesidade mórbida.");
				}
				Console.WriteLine("Póximo cliente?");
				op = Console.ReadLine();	
			} while (op == "sim");
			Console.WriteLine("Até a próxima!");
			Console.Read();
		}
	}
}
