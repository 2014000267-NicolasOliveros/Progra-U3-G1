using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lecc16_Act2_Inci2");

        int[] numeros = new int[8];
        int mayor, posicion;

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Ingrese el número " + (i + 1) + ": ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        mayor = numeros[0];
        posicion = 0;

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
                posicion = i;
            }
        }

        Console.WriteLine();
        Console.WriteLine("El número mayor es: " + mayor);
        Console.WriteLine("Está en la posición: " + (posicion + 1));

        Console.ReadKey();
    }
}
