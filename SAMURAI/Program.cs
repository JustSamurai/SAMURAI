using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMURAI
{
    internal class Program
    {
        static private void Answer()
        {
            string ask = Console.ReadLine();
            int choice = 0;
            if(ask != null) 
            { 
                choice++;
            }
            switch (choice)
            {
                case 0:
                    do 
                    { 
                        Console.WriteLine("waiting...");
                    }
                    while(choice == 0);
                    break;
                case 1:
                    Console.WriteLine("SAMURAI: Answer...");
                    break;
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Answer();
        }
    }
}
