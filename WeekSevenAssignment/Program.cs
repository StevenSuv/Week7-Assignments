using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Enter your username");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter your password");
                string userPass = Console.ReadLine();
                Console.WriteLine("Enter your PIN");
                string userPIN = Console.ReadLine();
                int pinLength = userPIN.Length;

                    if (pinLength > 4)
                    {
                        Console.WriteLine("Wrong PIN. Try again.");
                    }
                    else
                    {
                        if (userName == "admin" && userPass == "admin1234" && userPIN == "0000")
                        {
                            Console.WriteLine("Welcome!");
                            break;
                        }
                        else
                        {
                            i = i + 1;
                            Console.WriteLine($"Incorrect username or password. {3 - i} tries left.");
                        }
                    }
            }
        }
    }
}
