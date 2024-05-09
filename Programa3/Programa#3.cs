using System;

namespace Programa3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double numero3;
            double numero4;
            double suma;
            double producto;

            try
            {
                Console.WriteLine("Ingresar el primer numero:");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresar el sugundo numero:");
                numero2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" INgresar el tercer numero:");
                numero3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresar el cuarto numero :");
                numero4 = Convert.ToDouble(Console.ReadLine());

                suma = numero1 + numero2 + numero3 + numero4;

                producto = suma / 4;

                Console.WriteLine(" La suma de todos los numero es " + suma);
                Console.WriteLine("El producto de todos los numero es " + producto);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"El error de encuatra aqui {ex.Message}");
            }
        }
    }
}