using System;
namespace LabWorkTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputKey;
            Console.WriteLine("Введите любой символ:");
            for (;;)
            {
                if (int.TryParse(Console.ReadLine(), out inputKey))
                {
                    Console.WriteLine(inputKey + " является цифрой");
                }
                else
                {
                    Console.WriteLine("Данный символ не является цифрой");
                }
            }
        }
    }
}
