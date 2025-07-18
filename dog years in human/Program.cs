using System;
using System.Linq.Expressions;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Elige una opcion \n Press 1 for Human Age to Dog Age \n Press 2 for Dog Age to Human Age"); 
            int option = Convert.ToInt16(Console.ReadLine());
            int humanAge;
            double dogAge;

            switch (option)
            {
                case 1:
                    //Pregunta cual es tu edad
                    Console.WriteLine("How old are you?");
                    //Usuario responde con su edad
                    humanAge = Convert.ToInt32(Console.ReadLine());
                    //dogAge dice que 1 año perruno equivale a 15 años humanos
                    dogAge = 15;
                    //newdogAge dice tus años humanos en años perrunos
                    double newdogAge = humanAge / dogAge;
                    //Muestra en pantalla tu edad y tu edad en años de perro aprox
                    Console.WriteLine($"You are {humanAge} and you age on dog age is {newdogAge:F2}");
                    break;
                case 2:
                    //Pregunta cual es tu edad
                    Console.WriteLine("How old is your dog?");
                    //Usuario responde con la edad de su perro
                    dogAge = Convert.ToInt32(Console.ReadLine());
                    //dogAge dice que 15 años humanos equivalen a 1 año perruno
                    humanAge = 15;
                    //newdogAge dice tus años humanos en años perrunos
                    double newhumanAge = dogAge * humanAge;
                    //Muestra en pantalla tu edad y tu edad en años de perro aprox
                    Console.WriteLine($"You dog is {dogAge} years old and his age in human years is {newhumanAge:F2}");
                    break;
                default:
                    Console.WriteLine("La opcion no es valida vuelva a ejecutar el programa");
                    break;
            }
        }
    }
}
