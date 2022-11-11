using System;

namespace magicheskichisla
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int magicNumber = int.Parse(Console.ReadLine());
                int proizv = 1;

                for (int i = 100000; i <= 999999; i++)
                {

                    int n = i;

                    do
                    {
                        proizv = proizv * (n % 10);
                        n = n / 10;
                    } while (n > 0);

                    if (proizv == magicNumber)
                    {
                        Console.Write("{0} ", i);
                    }

                }
            }
        }
    }

}


