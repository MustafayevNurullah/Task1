

using System;

namespace Task1
{
    class Program
    {

       
       
        static void Main(string[] args)
        {
            while(true)
            { 
            Console.WriteLine("Enter number");
            var number = Console.ReadLine();
               
                if (uint.TryParse(number, out uint  output) & number!=null)
                {
                    Console.WriteLine("Result");
                      Single_Number(output);
                break;
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            }



            
           

             void Single_Number(uint number)
            {
                Console.Clear();
                for (int i = 0; i < number; number--)
                {
                    if (number % 2 != 0)
                    {
                        Console.WriteLine(number);
                    }
                }
            }
        }
    }
}
