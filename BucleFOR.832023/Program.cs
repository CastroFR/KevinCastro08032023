

class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido al programa de Kevin Castro! \nIngresa un número entero para la altura del triángulo: ");
            int altura = int.Parse(Console.ReadLine());

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                    Console.WriteLine();
    
            }
    } 
}
