using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float l, a, e, media;
            string c;
            c = "";
            Console.WriteLine("Digite a nota do trabalho do laboratório.");
            l = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da avaliação semestral.");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do exame final.");
            e = float.Parse(Console.ReadLine());
            media = (l * 2 + a * 3 + e * 5) / (2 + 3 + 5);
            if (media < 0 || media > 10)
            {
                Console.Write("Nota inválida!");
            }
            else
            {
                if (media >= 8 && media <= 10)
                {
                    c = "A";
                }
                else
                    if (media >= 7 && media < 8)
                    {
                        c = "B";
                    }
                    else
                        if (media >= 6 && media < 7)
                        {
                            c = "C";
                        }
                        else
                            if (media >= 5 && media < 6)
                            {
                                c = "D";
                            }
                            else
                                c = "E";

                Console.Write("Média: {0:0.00} Conceito: {1}", media, c);
            }
            Console.Read();
        }
    }
}
