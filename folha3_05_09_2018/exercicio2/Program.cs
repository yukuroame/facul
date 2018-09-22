using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int c;
            float s, ns,a ;
            Console.WriteLine("Nome do(a) fulano(a)?");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o salário atual.");
            s = float.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite o cargo. \n1 para Escriturário. \n2 para Secretário. \n3 para Caixa. \n4 para gerente. \n5 para diretor.");
            c = int.Parse(Console.ReadLine());
            switch (c) 
            {
                case 1:
                    a = s * 50 / 100;
                    ns = s + a;
                    Console.Write("Nome: {0} \nCargo: Escriturário(a) \nValor do aumento R$: {1:0.00} \nNovo salário R$: {2:0.00}",nome, a, ns);
                    break;
                case 2:
                    a = s * 35 / 100;
                    ns = s + a;
                    Console.Write("Nome: {0} \nCargo: Secretário(a) \nValor do aumento R$: {1:0.00} \nNovo salário R$: {2:0.00}", nome, a, ns);
                    break;
                case 3:
                    a = s * 20 / 100;
                    ns = s + a;
                    Console.Write("Nome: {0} \nCargo: Caixa \nValor do aumento R$: {1:0.00} \nNovo salário R$: {2:0.00}", nome, a, ns);
                    break;
                case 4:
                    a = s * 10 / 100;
                    ns = s + a;
                    Console.Write("Nome: {0} \nCargo: Gerente \nvalor do aumento R$: {1:0.00} \nNovo salário R$: {2:0.00}", nome, a, ns);
                    break;
                case 5:
                    Console.Write("Nome: {0} \nCargo: Diretor \nDiretor não tem aumento! \nSalário R$: {1:0.00}", nome, s);
                    break;
                default:
                    Console.Write("Estagiotario não tem vez, vaza!");
                    break;
            }



            Console.Read();
        }
    }
}
