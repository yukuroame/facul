﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numeros = new int[10];
			int cont, maior;
			for (cont = 0; cont <= 9; cont++)
			{
				Console.WriteLine("Digite o {0}º número.", cont + 1);
				numeros[cont] = int.Parse(Console.ReadLine());
			}
			maior = numeros[0];
			for (cont = 1; cont <= 9; cont++)
			{
				if (maior < numeros[cont])
					maior = numeros[cont];

				
			}
			for (cont = 0; cont <= 9; cont++)
			{
				if (maior == numeros[cont])
					Console.WriteLine("O maior número é: {0}, e a posição é: {1}", maior, cont);
				
			}
			Console.Read();
		}
	}
}
