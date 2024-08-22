using System;
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite quantas linhas e colunas terá a Matriz: ");
        string[] lc = Console.ReadLine().Split(' ');
        int l = int.Parse(lc[0]);
        int c = int.Parse(lc[1]);

        int[,] mat = new int[l, c];

        for (int lin = 0; lin < l; lin++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            for (int col = 0; col < c; col++)
            {
                mat[lin,col] = int.Parse(valores[col]);
            }
        }
        Console.WriteLine();
        Console.Write("Digite um número que consta na Matriz: ");
        int nm = int.Parse(Console.ReadLine());

        for (int lin = 0; lin < l; lin++)
        {
            for (int col = 0; col < c; col++)
            {                
                if (mat[lin,col] == nm)
                {
                    Console.WriteLine("A posição desse número é: (" + lin + ", " + col + ")");
                    if (col > 0)
                    {
                        Console.WriteLine("Número a esquerda: " + mat[lin,col - 1]);
                    }
                    if (lin > 0)
                    {
                        Console.WriteLine("Número a cima: " + mat[lin - 1, col]);
                    }
                    if (col < c - 1)
                    {
                        Console.WriteLine("Número a direita: " + mat[lin, col + 1]);
                    }
                    if (lin < l - 1)
                    {
                        Console.WriteLine("Número a baixo: " + mat[lin + 1, col]);
                    }
                }
            }
        }
    }
}