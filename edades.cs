internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("DATOS ACADÉMICOS\nNicolás Oliveros\n4to Bachillerato en CCLL con orientación en Computación\nSección 'C'\nClave 26");

        int[] edadpersonas = new int[7];
        int cantpermay = 0;
        int cantpermen = 0;

        for (int i = 0; i < edadpersonas.Length; i++)
        {
            Console.WriteLine();
            Console.Write("Ingrese la edad de la persona " +(i+1)+":");
            edadpersonas[i] = Convert.ToInt32(Console.ReadLine());

            if (edadpersonas[i] >= 18)
            {
                cantpermay++;
            }
            else
            {
                cantpermen++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Cantidad de Personas Mayores de edad: " +cantpermay);
        Console.WriteLine("Cantidad de Personas Menores " + cantpermen);
    }
}
