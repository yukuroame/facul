using System;

namespace exerc2_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            float horas_t, vlr_sal_min, vlr_hora_t, vlr_sal_bru, imp, vlr_sal_liq;
            Console.WriteLine("Digite o total de horas trabalhadas: ");

            horas_t = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do sal rio minimo: ");

            vlr_sal_min = float.Parse(Console.ReadLine());
            vlr_hora_t = vlr_sal_min / 2;
            vlr_sal_bru = vlr_hora_t * horas_t;
            imp = vlr_sal_bru * 3 / 100;
            vlr_sal_liq = vlr_sal_bru - imp;
            Console.WriteLine("O sal rio a receber ‚: {0} ", vlr_sal_liq);
            Console.ReadKey();
        }
    }
}
