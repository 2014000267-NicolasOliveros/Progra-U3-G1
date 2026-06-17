using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numeros = new int[15];
        bool repetido = false;

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Ingrese el número " + (i + 1) + ": ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = i + 1; j < numeros.Length; j++)
            {
                if (numeros[i] == numeros[j])
                {
                    repetido = true;
                }
            }
        }

        Console.WriteLine();

        if (repetido)
        {
            Console.WriteLine("Sí hay números repetidos en el arreglo.");
        }
        else
        {
            Console.WriteLine("No hay números repetidos en el arreglo.");
        }

        Console.ReadKey();
    }
}
