﻿namespace ProyectoGitCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte op;
            int num1, num2, suma, resta, multiplicacion;
            float division;
            Console.WriteLine("Calculadora básica");
            Console.WriteLine("Elige que operación quieres realizar:");
            Console.WriteLine("1.- Suma");
            Console.WriteLine("2.- Resta");
            Console.WriteLine("3.- Multiplicación");
            Console.WriteLine("4.- División");
            Console.WriteLine("5.- Cancelar/Salir");
            op = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Introduce el primer valor entero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo valor entero");
            num2 = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:





















                    break;
                case 2:


                    


















                    break;
                case 3:





















                    break;
                case 4:
                    division = num1 / num2;
                    Console.WriteLine($"El resultado de la división entre {0} y {1} es {2}", num1, num2, division);
                    break;
                default:
                    Console.WriteLine("Saliendo...");
                    break;
            }
        }
    }
}