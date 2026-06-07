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
            //to check if input is null
            var input = Console.ReadLine();
            if (input == null) Environment.Exit(0);

            if(int.TryParse(input,out var number))
                {
                    return number;
                }
                System.Console.WriteLine("Please enter a valid number");
        }
        }
        public static int ReadPositiveNumber(string message)
        {
            while (true)
            {
                var number=ReadNumber(message);
                if (number > 0)
                {
                    return number;
                }
                System.Console.WriteLine("Quantity must be greater than zero");
            }
            
        }

        public static bool ReadYesNo(string message)
        {
            while (true)
            {
                System.Console.WriteLine(message);
                var ans=Console.ReadLine()?.Trim().ToLowerInvariant();
                if (ans == "y")
                {
                    return true;
                }
                if (ans == "n")
                {
                    return false;
                }
                System.Console.WriteLine("Please enter y or n");
            }
            
        }
         public static T ReadChoice<T>(string message, Dictionary<int, T> choices, string invalidMessage)
    {
        
        while (true)
        {
            var choice = ReadNumber(message);
            //check if return empty string
            if (choices == null || choices.Count == 0)
           throw new InvalidOperationException("No payment options available");

            if (choices.TryGetValue(choice, out var selectedChoice))
            {
                return selectedChoice;
            }

            Console.WriteLine(invalidMessage);
        }
         
        }
        
    
    }}