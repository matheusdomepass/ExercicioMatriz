﻿using System;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linha = Console.ReadLine().Split(' ');

            int m = int.Parse(linha[0]);
            int n = int.Parse(linha[1]);

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valor[j]);
                }
            }
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Posição " + i + "," + j + ":");
                    }
                    if (j > 0)
                    {
                        Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                    }
                    if (i > 0)
                    {
                        Console.WriteLine("Cima: " + matriz[i - 1, j]);
                    }
                    if (j < n - 1)
                    {
                        Console.WriteLine("Direita: " + matriz[i, j + 1]);
                    }
                    if (i < m - 1)
                    {
                        Console.WriteLine("Baixo: " + matriz[i + 1, j]);
                    }
                }
            }
        }
    }
}