using System;

namespace b3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("素数");
            for(int i = 2; i < 100; i++)
            {
                if (i % 2 != 0&&i!=2)
                {
                    if(i % 3 != 0 && i != 3)
                    {
                        if (i % 5 != 0 && i != 5)
                        {
                            if (i % 7 != 0 && i != 7)
                            {
                                Console.WriteLine(i);
                              //  Console.WriteLine("/n");
                            }
                        }
                    }
                }
            }
        }
    }
}
