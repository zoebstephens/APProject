using System;
using System.Collections.Generic;

namespace APProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

        public BreakfastGame(int minimum, int maximum)
        {
            this.minimum = minimum;
            this.maximum = maximum;
        }

        public static void Play(int minimum, int maximum)
        {
    
            List<int> guesses; // A list of all the players inputs

            inputs.Add(playerInput);

            while (playerInput < 3)
            {
                Console.WriteLine(CheckGuess(playerGuess, randomNumber));
                playerGuess = GetGuess(minimum, maximum);
                guesses.Add(playerGuess);
            }

            DisplayReport(guesses);
        }


        public int GetBreakfast()
        {
            int input;
            Console.WriteLine($"Enter a number between {this.minimum} and {this.maximum}:");
            input= int.Parse(Console.ReadLine());
            if (input < this.minimum || input > this.maximum)
            {
                Console.Error.WriteLine("Invalid input!");
                return this.GetBreakfast();
            }

            return input;
        }

        public static int GetValidAnswer(List<string> answers)
        {
            // Validate that there is at least 1 possible answer.
            // If the list of answers is empty, throw an exception
            // Otherwise, Display a message asking the user to select an option.
            // Store the user's response in a variable name choice
            // Validate that choice is one of the possible answers
            // If it is not a valid answer
            // Display an error message
            // Go to 3
            // Otherwise, return the user's choice.
            if (answers.Count == 0)
            {
                throw new Exception($"At least one possible answer does not exist.");
            }

            Console.WriteLine("Select an Option");
            int userChoice;

            do
            {
                Console.Write($"Enter a number between 1 and {answers.Count}: ");
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
                else if (userChoice > answers.Count)
                {
                    Console.Error.WriteLine($"That number is not less than {answers.Count}.");
                }
            }
            while (userChoice < 1 || userChoice > answers.Count);

            return userChoice -1;
        }


        public string CheckInput (int input)
        {
            if (input > this.comboMealNumber)
            {
                return "Your number of selected breakfast options is too low.";
            }
            else
            {
                return "Your number of selected breakfast options is too high.";
            }
        }

    
        public void DisplayReport()
        {
            Console.WriteLine("You selected the 3 piece combo breakfast!");
            if (this.inputs.Count > 1)
            {
                Console.WriteLine($"You didn't select the correct number of items {this.inputs.Count - 1} times.");
                Console.Write("Inputs:");
                foreach (int input in this.inputs)
                {
                    Console.Write($"{input}");
                }
            }
            else
            {
                Console.WriteLine("You selected the correct number of items on the first try! Yay you!");
            }

        
        public static string GetBreakfast()
        {
            List<string> words = new List<string>();
            words.Add("bagel");
            words.Add("ego waffle");
            words.Add("cereal");
            words.Add("sausage");
            words.Add("pancake");
            words.Add("avocado toast");
            words.Add("oatmeal");
            words.Add("acai bowl");
            words.Add("eggs");
            words.Add("yogurt");
            words.Add("breakfast burrito");
            words.Add("fruit platter");
            words.Add("crepe");
            words.Add("croissant");
            words.Add("blueberry muffin");
            words.Add("chocolate chip pancake");
            words.Add("banana nut muffin");
            words.Add("french toast");
            words.Add("toast and jam");
            words.Add("smoothie");


            return Breakfast;
        }
    }
}
