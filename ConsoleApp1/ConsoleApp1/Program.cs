using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Ingrese el tamaño del rombo (o 'X' para salir): ");
            string input = Console.ReadLine();

            if (input.ToUpper() == "X")
            {
                Console.WriteLine("¡Programa finalizado!");
                break;
            }

            if (!int.TryParse(input, out int size))
            {
                Console.WriteLine("Entrada inválida. Por favor ingrese un número impar o 'X' para salir.");
                continue;
            }

            if (size % 2 == 0 || size < 1)
            {
                Console.WriteLine("Por favor ingrese un número impar positivo.");
                continue;
            }

            int half = size / 2 + 1;

            // top 
            for (int i = 1; i <= half; i++)
            {
                Console.Write(new string(' ', half - i));
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }

            // lower part 

            for (int i = half - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', half - i));
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(); // space between diamonds
        }
    }
}
