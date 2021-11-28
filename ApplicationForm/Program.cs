using System;

namespace ApplicationForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, как вас зовут? ");
            string userName = Console.ReadLine();
            
            Console.WriteLine("Сколько вам лет? ");
            byte userAge = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Какое у вас хобби?");
            string userHobby = Console.ReadLine();

            Console.WriteLine($"\nВас зовут: {userName}\n" +
                $"Ваш возраст: {userAge}\n" +
                $"Вы увлекаетесь: {userHobby}");
        }
    }
}
