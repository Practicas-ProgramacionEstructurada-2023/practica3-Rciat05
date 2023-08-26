using System;
using System.Drawing;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            string? Marca_Zapato;
            string? Color_Zapato;
            int Cantidad;
            double Precio_Zapato;

            //Captura de datos
            Console.WriteLine("\n ----Captura de datos variables----");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ingrese la marca de zapatos a comprar: ");
            Marca_Zapato= Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nIngrese el color del par de zapatos:");
            Color_Zapato= Convert.ToString(Console.ReadLine());

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("\nIngrese la cantidad de pares de zapatos a comprar: ");
            Cantidad = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("\nIngrese el precio del par de zapatos a comprar:");
            Precio_Zapato = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("----Fin de capturación de variables----\n");

            double Total = Cantidad * Precio_Zapato; 

            //Imprimiento resultado
            Console.WriteLine("--------Imprimiendo resultados--------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("La marca de zapatos a comprar es: " + Marca_Zapato);
            Console.WriteLine("\nEl color de zapatos a comprar es: " + Color_Zapato);

            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("\nLa cantidad de pares de zapatos a comprar es: " + Cantidad);
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("\nPrecio por par de zapatos a comprar es: " + Precio_Zapato);
            Console.ForegroundColor = ConsoleColor.Magenta; 
            Console.BackgroundColor = ConsoleColor. Yellow;
            Console.WriteLine("\nEl total a pagar es: " + Total);
            Console.ResetColor();       //Aqui termina el foreground para agregar color. 
            Console.WriteLine("-------- Fin de imprimir resultados--------\n");
          

        }
    }
} 