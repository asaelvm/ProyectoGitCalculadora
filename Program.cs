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
            switch(op)
            {
                case 1:





















                    break;
                case 2:





















                    break;
                case 3:





















                    break;
                case 4:





















                    break;
                default:
                    Console.WriteLine("Saliendo...");
                    break;
            }
        }
    }
}