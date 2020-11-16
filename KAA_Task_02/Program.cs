using System;

namespace KAA_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите exit: ");
            string word = Console.ReadLine();
            while (!word.Contains("exit"))
            {
                if (word != "exit")
                {
                    Console.Write("Повторите попытку ");
                    word = Console.ReadLine();
                }
            }

        }
    }
}