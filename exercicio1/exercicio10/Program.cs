using System;

namespace exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double aa, ip, anp, if1, if2, anf1, anf2;
            Console.WriteLine("Digite o ano atual.");
            aa = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu nome.");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade.");
            ip = double.Parse(Console.ReadLine());
            if1 = Math.Sqrt(ip);
            if1 = Math.Floor(if1);
            if2 = if1 - 1;
            anp = aa - ip;
            anf1 = aa - if1;
            anf2 = aa - if2;
            Console.WriteLine("nome do usuário: {0} \nidade: {1} \nano de nascimento: {4} \nidade do filho mais velho: {2} \nano de nascimento:{5}\nidade do filho caçula: {3} \nano de nascimento:{6}", nome, ip, if1, if2, anp, anf1, anf2);
            Console.Read();
        }
    }
}
