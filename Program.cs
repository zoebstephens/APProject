using System;
using System.Collections.Generic;

namespace APProject
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }



        public static List<BreakfastItem> GetBreakfast()
        {
            List<BreakfastItem> BreakfastCombo = new List<BreakfastItem>();
            BreakfastItem bananaBread = new BreakfastItem();
            bananaBread.Description = "Delicious Banana Bread";
            bananaBread.price = 4;
            
            BreakfastItem waffle = new BreakfastItem();
            waffle.Description = "Delicious Waffle";
            waffle.price = 8;

            BreakfastItem cereal = new BreakfastItem();
            cereal.Description = "Delicious Cereal";
            cereal.price = 2;

            BreakfastItem pancake = new BreakfastItem();
            pancake.Description = "Delicious Pancake";
            pancake.price = 7;

            BreakfastItem bagel = new BreakfastItem();
            bagel.Description = "Delicious Bagel";
            bagel.price = 1;

            BreakfastItem croissant = new BreakfastItem();
            croissant.Description = "Delicious Croissant";
            croissant.price = 5;

            BreakfastItem oatmeal = new BreakfastItem();
            oatmeal.Description = "Delicious Oatmeal";
            oatmeal.price = 2;

            BreakfastItem eggs = new BreakfastItem();
            eggs.Description = "Delicious Eggs";
            eggs.price = 3;

            BreakfastItem crepe = new BreakfastItem();
            crepe.Description = "Delicious Crepe";
            crepe.price = 10;

            BreakfastItem blueberryMuffin = new BreakfastItem();
            blueberryMuffin.Description = "Delicious Blueberry Muffin";
            blueberryMuffin.price = 6;

            BreakfastCombo.Add(bananaBread);
            BreakfastCombo.Add(waffle);
            BreakfastCombo.Add(cereal);
            BreakfastCombo.Add(pancake);
            BreakfastCombo.Add(bagel);
            BreakfastCombo.Add(croissant);
            BreakfastCombo.Add(oatmeal);
            BreakfastCombo.Add(eggs);
            BreakfastCombo.Add(crepe);
            BreakfastCombo.Add(blueberryMuffin);
    

            foreach(BreakfastItem item in BreakfastCombo)
            {
                Console.WriteLine($"{item.Description}");
            }

            return BreakfastCombo;

        }

        public static int GetDescription(BreakfastItem description)
        {
            if (description == null)
            {
                throw new ArgumentNullException("Description can not be null");

            }

            List<string> items = description.items;

            if (items.Count == 0)
            {
                throw new ArgumentException("The list must contain at least 1 option");
            }

            Console.WriteLine(description.Description);

            int ix = 1;
            foreach (string item in items)
            {
                Console.WriteLine($"{ix}. {items}");
                ix = ix + 1;
            }

            // Display Description (List of Options
            // Loop through each answer and display it 
            // Use GetUserInput method to get the user's response
            return GetUserInput(description.items);
        }

        public static int GetUserInput(List<string> items)
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

            Console.WriteLine("Select an Option");
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
    }
}

public class BreakfastItem
{
    public string Description;
    public decimal price;

    public List<string> items = new List<string>();
}

