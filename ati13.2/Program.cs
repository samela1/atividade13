using System;

namespace ati13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhamatriz;
            float notas;
            Console.WriteLine("Quantidades de diciplinas ");
            linhamatriz = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhamatriz , 4 ];

            for (int linha = 1; linha <= linhamatriz; linha++ )
            {
                for (int coluna = 0; coluna <= 4; coluna++ )
                {
                    Console.Write("Digite suas notas seguencialmente  "  +  ( linha )  +  "  unidade  "   +  ( coluna ));
                    notas =
                        float.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}