﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio07
{
	class Program
	{
		static void Main(string[] args)
		{
			int x, par, maior, menor, soma, z;
			float media, y;
			x = 1;
			y = 0;
			par = 0;
			soma = 0;
			z = 1;
			maior = 1;
			menor = 1;
			while (x != 0)
			{
				Console.WriteLine("Digite o número.");
				x = int.Parse(Console.ReadLine());
				if (x == 0)
				{
					break;
				}
				y++;
				soma += x;
				if (x % 2 == 0)
				{
					par++;
				}
				if (x < z)
				{
					menor = x;
				}
				else
				{
					maior = x;
				}
				z = x;
				
			}
			media = soma / y;
			Console.WriteLine("números digitados:{0} \npares: {1} \nMaior valor: {2} \nmenor valor: {3} \nsoma: {4} \nmédia aritmética: {5:0.00}", y, par, maior, menor, soma, media);
			Console.Read();
		}
	}
}
