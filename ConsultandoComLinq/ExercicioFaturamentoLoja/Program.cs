using System;
using System.Linq;

namespace ExercicioFaturamentoLoja
{
    class Program
    {
        static void Main(string[] args)
        {
            var dias = new[] {
                new { nome = "segunda", faturamento = 1000 },
                new { nome = "terça", faturamento = 2000 },
                new { nome = "quarta", faturamento = 12500 },
                new { nome = "quinta", faturamento = 11000 },
                new { nome = "sexta", faturamento = 22000 },
                new { nome = "sábado", faturamento = 9000 },
                new { nome = "domingo", faturamento = 18000 }};

            //Essa loja quer saber quais dias consecutivos tiveram faturamento igual ou superior a 10 mil reais.
            //Qual consulta LINQ pode trazer esse resultado ?

            var consulta = dias
                .Where(x => x.faturamento > 10000);
            foreach(var c in consulta)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();

            //Ou

            var query = dias
                .SkipWhile(d => d.faturamento < 10000)
                .TakeWhile(d => d.faturamento >= 10000);
            foreach (var q in query)
            {
                Console.WriteLine(q);
            }

        }
    }
}
