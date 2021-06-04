using System;

namespace odev_extesions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (true)
            {
                Console.WriteLine("\nMükemmel sayıyı bul, bir sayıyı giriniz\n");
                number = int.Parse(Console.ReadLine());

                var isPerfect = number.IsPerfectNumber();
                Console.WriteLine(isPerfect ? "Tebrikler mükemmel sayıyı buldunuz" : "Olmadı be canım, tekrar dene");
                number = 0;
            }
                Console.ReadLine();

        }
    }
}
