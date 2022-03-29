using System;

namespace ClassTask1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        enum Spisok {
            Registration=1,
            Autorisation=2,
            Fight=3,
            Exit=4,
            Generation=5
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Для выбора {Spisok.Registration} наберите  {(int)Spisok.Registration}");
            Console.WriteLine($"Для выбора {Spisok.Autorisation} наберите  {(int)Spisok.Autorisation}");
            Console.WriteLine($"Для {Spisok.Fight} наберите  {(int)Spisok.Fight}");
            Console.WriteLine($"Для {Spisok.Exit} наберите  {(int)Spisok.Exit}");
            Console.WriteLine($"Для выбора {Spisok.Generation} наберите  {(int)Spisok.Generation}");
            string input = Console.ReadLine();
            Spisok choice =(Spisok)int.Parse(input);
            Console.WriteLine($"Вы хотите {choice}");
            Console.WriteLine("$");
            Console.WriteLine("$");
            Console.WriteLine("$");
            Console.WriteLine("$");

        }
    }
}