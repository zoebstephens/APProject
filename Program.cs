using System;
using System.Collections.Generic;

namespace APProject
{
    class Program
    {
        private static int ix;
        static void Main(string[] args)
        {
            
            List<Food> breakfast = new List<Food>();
            Food bananaBread = new Food();
            bananaBread.Description = "Delicious Banana Bread";
            bananaBread.price = 4.75M;
            breakfast.Add(bananaBread);

            
            Food waffle = new Food();
            waffle.Description = "Delicious Waffle";
            waffle.price = 8.60M;
            breakfast.Add(waffle);

            Food cereal = new Food();
            cereal.Description = "Delicious Cereal";
            cereal.price = 2.50M;
            breakfast.Add(cereal);

            Food pancake = new Food();
            pancake.Description = "Delicious Pancake";
            pancake.price = 7.80M;
            breakfast.Add(pancake);

            Food bagel = new Food();
            bagel.Description = "Delicious Bagel";
            bagel.price = 1.99M;
            breakfast.Add(bagel);

            Food croissant = new Food();
            croissant.Description = "Delicious Croissant";
            croissant.price = 5.99M;
            breakfast.Add(croissant);

            Food oatmeal = new Food();
            oatmeal.Description = "Delicious Oatmeal";
            oatmeal.price = 2.75M;
            breakfast.Add(oatmeal);

            Food eggs = new Food();
            eggs.Description = "Delicious Eggs";
            eggs.price = 3.20M;
            breakfast.Add(eggs);


            Food crepe = new Food();
            crepe.Description = "Delicious Crepe";
            crepe.price = 10.99M;
            breakfast.Add(crepe);

            Food blueberryMuffin = new Food();
            blueberryMuffin.Description = "Delicious Blueberry Muffin";
            blueberryMuffin.price = 6.00M;
            breakfast.Add(blueberryMuffin);

            // BreakfastCombo.Add(bananaBread);
            // BreakfastCombo.Add(waffle);
            // BreakfastCombo.Add(cereal);
            // BreakfastCombo.Add(pancake);
            // BreakfastCombo.Add(bagel);
            // BreakfastCombo.Add(croissant);
            // BreakfastCombo.Add(oatmeal);
            // BreakfastCombo.Add(eggs);
            // BreakfastCombo.Add(crepe);
            // BreakfastCombo.Add(blueberryMuffin);
    
            ix = 1;
            foreach(Food item in breakfast)
            {
                Console.WriteLine($"{ix}. {item.Description}");
                ix = ix + 1;
            }
            Console.WriteLine("Pick an item!");
            ix = GetUserInput(breakfast);

            DisplayResult(breakfast, ix);

        }

        public static int GetUserInput(List<Food> items)
        {
            // Validate that there is at least 1 possible item.
            // If the list of items is empty, throw an exception
            // Otherwise, Display a message asking the user to select an option.
            // Store the user's response in a variable name choice
            // Validate that choice is one of the possible answers
            // If it is not a valid item
            // Display an error message
            // Go to 3
            // Otherwise, return the user's choice.
            if (items.Count == 0)
            {
                throw new Exception($"At least one possible item does not exist.");
            }

            int userChoice;

            do
            {
                Console.Write($"Enter a number between 1 and {items.Count}: ");
                string input = Console.ReadLine();

                bool isANumber = int.TryParse(input, out userChoice);

                if (isANumber == false)
                {
                    Console.Error.WriteLine("You did not enter a valid number.");
                }
                else if (userChoice < 1)
                {
                    Console.Error.WriteLine("That number is not greater than 1.");
                }
                else if (userChoice > items.Count)
                {
                    Console.Error.WriteLine($"That number is not less than {items.Count}.");
                }
            }
            while (userChoice < 1 || userChoice > items.Count);

            return userChoice - 1;
        }

    

        public static void DisplayResult(List<Food> breakfast, int userChoice)
        {
            Console.WriteLine($"${breakfast[userChoice].price}") ;
        }
    }


public class Food
{
    public string Description;
    public decimal price;

    public List<string> items = new List<string>();
}

}