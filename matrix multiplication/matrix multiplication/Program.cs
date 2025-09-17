using System;

class Program
{
    static void Main()
    {
        int m, n, p;

        Console.Write("Ingrese el valor de m: ");
        m = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor de n: ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor de p: ");
        p = int.Parse(Console.ReadLine());

        int[,] A = new int[m, n];
        int[,] B = new int[n, p];
        int[,] C = new int[m, p];

        // Fill matrix A with formula (i+1)*j
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                A[i, j] = (i + 1) * j;
            }
        }

        // Fill matrix B with formula (j+1)*i
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < p; j++)
            {
                B[i, j] = (j + 1) * i;
            }
        }

        // Multiply matrices A x B = C
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < p; j++)
            {
                int suma = 0;
                for (int k = 0; k < n; k++)
                {
                    suma += A[i, k] * B[k, j];
                }
                C[i, j] = suma;
            }
        }

        // Show matrix A
        Console.WriteLine("**** A ***");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Show matrix B
        Console.WriteLine("**** B ***");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < p; j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Show matrix C
        Console.WriteLine("**** C ***");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < p; j++)
            {
                Console.Write(C[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

