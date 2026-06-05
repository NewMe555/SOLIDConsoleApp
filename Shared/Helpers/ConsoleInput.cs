using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart_Food_Delivery.Restaurants.Model;

namespace Smart_Food_Delivery.Shared.Helpers
{
    public static class ConsoleInput
    {
        public static int ReadNumber(string message)
        {
            while (true)
        {
            Console.WriteLine(message);
            if(int.TryParse(Console.ReadLine(),out var number))
                {
                    return number;
                }
                System.Console.WriteLine("Please enter a valid number");
        }
        }
         
        }
        
    
}