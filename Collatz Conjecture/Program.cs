namespace CollatzConjecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start with a number n > 1. Find the number of steps it takes to reach one using
            //the following process: If n is even, divide it by 2. If n is odd, multiply it by 3 and add 1.
            int numero;
            int contador = 0;
            do
            {
                Console.WriteLine("Ingrese un numero mayor a 0");
                numero = int.Parse(Console.ReadLine());
            } while (numero <= 0);

            Console.WriteLine("============");
            do
            {
                if (esPar(numero) == true)
                {
                    numero /= 2;
                    contador++;
                }
                else if (esPar(numero) == false)
                {
                    numero = (numero * 3) + 1;
                    contador++;
                }
                Console.WriteLine(numero);
            } while (numero != 1);
            Console.WriteLine($"Se necesitaron {contador} pasos para llegar a 1");
        }

        static bool esPar(int numero)
        {
            if (numero % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}