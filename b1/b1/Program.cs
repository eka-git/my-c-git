using System;

namespace b1
{
    class Program
    {
        /**      static void analyse(int i)
              {
                  int j = 2;
                  while (i > 1)
                  {
                      for (j = 2; j < i; j++)
                      {
                          if (i % j == 0)
                          {
                              Console.WriteLine(j);

                              break;
                          }
                       
                      }
                  }
              }
              */
      static  bool prime(int n)
        {
            int i= 1;
            bool flag = true;
            for (i = 2; i <= n / 2; i++)
                if (n % i == 0)
                {
                    flag = false;
                    return flag;
                }
            return flag;
        }
        static void factor(int n)
        {
            int i;
            i = 2;
            while (i <= n)
            {
                if ((n % i == 0) && prime(i))
                {
                    Console.WriteLine( i);
                    Console.WriteLine("\n");
                    n = n / i;
                  //  continue;
                }
                i++;
            }
        }

        static void Main(string[] args)
        {
    
                Console.WriteLine("enter a number:");
                int num = int.Parse(Console.ReadLine());
                int j = 2;
            /**               while (num > 1 || j < num)
                           {
                         
                               if (num % j == 0&&j>0)
                               {
                               
                                   Console.WriteLine(j);

                                   //  break;
                               }
                               j++;
                              
                           }
            */
            //    Console.WriteLine("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            //     if (Console.ReadLine() == "n") endApp = true;
            factor(num);
                Console.WriteLine("\n"); // Friendly linespacing.
            }
        
    }
}
