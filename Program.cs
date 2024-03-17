using System;

namespace LoginApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int right = 3;

            while (true)
            {
                Console.Write("Kullanıcı adınızı giriniz: ");
                string userName = Console.ReadLine();

                Console.Write("Şifrenizi giriniz: ");
                string password = Console.ReadLine();

                if (userName == "enes" && password == "123")
                {
                    Console.WriteLine("Tebrikler, başarılı bir şekilde giriş yaptınız!");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı adınız veya şifreniz yanlış!");

                    if (right > 0)
                    {
                        right--;
                    }
                    if (right == 0)
                    {
                        Console.WriteLine("Hakkınız dolmuştur, daha fazla giriş yapamazsınız!");
                        break;
                    }
                }                
            }
            Console.ReadLine();
        }
    }
}
