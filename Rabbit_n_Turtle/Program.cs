using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Rabbit_n_Turtle
{
    class Program
    {
        public static int x = 0;
        public static int y = 0;
        static void Main(string[] args)
        {
            Thread rabbit = new Thread(RabbitRun);
            Thread turtle = new Thread(TurtleRun);
            rabbit.Start();
            turtle.Start();

            while (x == 50 || y == 50)
            {
                if (x > (y + 5))
                {
                    turtle.Priority = ThreadPriority.Normal;
                    rabbit.Priority = ThreadPriority.Lowest;
                }
                if (y > (x + 5))
                {
                    turtle.Priority = ThreadPriority.Lowest;
                    rabbit.Priority = ThreadPriority.Normal;
                }

            }

            Console.ReadLine();
        }
                public static void RabbitRun()
                {
                    for (x = 0; x < 200; x++)
                    {
                        Console.WriteLine($"Кролик пробежал " + x + " метров");
                    }
                }

                public static void TurtleRun()
                {
                    for (x = 0; x < 200; x++)
                    {
                        Console.WriteLine($"Черепаха пробежала " + x + " метров");
                    }
                }
            
        
    }
}
