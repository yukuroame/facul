using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;
            Console.WriteLine("Digita o número de mês.");
            mes = int.Parse(Console.ReadLine());
            switch (mes)
            {
                case 1:
                    Console.Write("Janeiro: possui 31 dias");
                    break;
                case 2:
                    Console.Write("Fevereiro: possui 28 dias");
                    break;
                case 3:
                    Console.Write("Março: possui 31 dias");
                    break;
                case 4:
                    Console.Write("Abril: possui 30 dias");
                    break;
                case 5:
                    Console.Write("Maio: possui 31 dias");
                    break;
                case 6:
                    Console.Write("Junho: possui 30 dias");
                    break;
                case 7:
                    Console.Write("Julho: possui 31 dias");
                    break;
                case 8:
                    Console.Write("Agosto: possui 31 dias");
                    break;
                case 9:
                    Console.Write("Janeiro: possui 30 dias");
                    break;
                case 10:
                    Console.Write("Janeiro: possui 31 dias");
                    break;
                case 11:
                    Console.Write("Janeiro: possui 30 dias");
                    break;
                case 12:
                    Console.Write("Janeiro: possui 31 dias");
                    break;
                default:
                    Console.Write("Não existe esse mês!");
                    break;
            }
            Console.Read();
        }
    }
}
