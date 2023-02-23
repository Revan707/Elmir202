using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 9;
            int n1 = 0;
            int n2 = 1;
            int n3=1;
           while(n3<num)
            {
                Console.WriteLine(n3);
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                
                


                
            }
           
        }
    }
}
