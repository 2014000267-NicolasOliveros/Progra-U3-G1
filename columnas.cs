internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nicolás Oliveros\nIV Bachillerato 'C'\nClave 26");
        int filas = 3;
        int columnas = 5;
        int i = 0; int j = 0;
        int[,] matriz1 = new int[3, 5];

        for(i = 0; i < filas; i++)
        {
            for(j = 0; j < columnas; j++)
            {
                Console.WriteLine("Ingrese el numero que quiera guardar en la fila: " + i + ", Columna: " + j + " =");
                matriz1[ i,j] = int.Parse(Console.ReadLine());
            }
        }
        for (i = 0; i < filas; i++)
        {
            for (j = 0;j < columnas; j++)
            {
                Console.WriteLine("Fila: "+i+", Columna: "+j+" = " + matriz1[i,j]);
            }
        }
        Console.WriteLine("Presione cualquier tecla para salir");
        Console.ReadKey();
    }
}
