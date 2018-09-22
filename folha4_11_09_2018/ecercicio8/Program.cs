using System;

namespace ecercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, c;
            double sa, ns;
            Console.WriteLine("Digite o seu nome!");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu salário!");
            sa = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua categoria!");
            c = Console.ReadLine();
            if (c == "a" || c == "f" || c == "c" || c == "h")
            {
                ns = sa * 1.1;
            }
            else
            {
                if (c == "b" || c == "d" || c == "e" || c == "i" || c == "j" || c == "t")
                {
                    ns = sa * 1.15;
                }
                else
                {
                    if (c == "k" || c == "r")
                    {
                        ns = sa * 1.25;
                    }
                    else
                    {
                        if (c == "l" || c == "m" || c == "n" || c == "o" || c == "p" || c == "q" || c == "s")
                        {
                            ns = sa * 1.35;
                        }
                        else
                            if (c == "u" || c == "v" || c == "w" || c == "x" || c == "y" || c == "z")
                            {
                                ns = sa * 1.5;
                            }
                            else
                            {
                            Console.Write("Categoria inválida!");
                            Console.ReadKey();
                            return;
                            }
                    }
                }
            }
            Console.Write("nome: {0} \nCategoria: {1} \nNovo salário: {2:0.00}", nome, c, ns);
            Console.Read();
        }
    }
}
