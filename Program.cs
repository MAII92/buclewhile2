namespace buclewhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int minumero = 101;

            int intentos = 0;

            Console.WriteLine("introduce un no° entre 0  y 100");

            while (aleatorio != minumero)
            {
                intentos++;

                minumero = int.Parse(Console.ReadLine());

                if (minumero > aleatorio) Console.WriteLine("El n° es mas bajo");

                if (minumero < aleatorio) Console.WriteLine("El n° es mas alto");



            }
                 
                      Console.WriteLine($"correcto! has nececitado {intentos}intentos");
        }
    }
}