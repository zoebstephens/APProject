# AP Project Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

A person would run my program to get the price of a breakfast item for entertainment. 


### 3a ii.

Describes what functionality of the program is demonstrated in the video.

My video demonstrates that my program can output the price of breakfast items when selected. 

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program accepts user input from the keyboard. The user enters a number between 1 and 10. Then my program outputs the price of the breakfast item that corresponds with the number the user inputted. 

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
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

```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
foreach(Food item in breakfast)
            {
                Console.WriteLine($"{ix}. {item.Description}");
                ix = ix + 1;
            }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable "breakfast".

### 3b iv.

Describes what the data contained in the list represents in your program

This list contains the different breakfast options that a user can select. 

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

My list manages complexity by allowing the breakfast index to contain unlimited amounts of breakfast items instead of using multiple if/else statements to generate breakfast items. This makes the addition of more breakfast items simpler instead of having to write another variable for each one. 

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
 public static int GetUserInput(List<Food> items)
        {
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

```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
Console.WriteLine("Pick an item!");
            ix = GetUserInput(breakfast);

            DisplayResult(breakfast, ix);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

Given a list of food items to display, this method iterates through the List, displaying it to the user then validates the users input. This is the main functionality of my program because it is used each time a user selects a breakfast item. 

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1. Validates that the user selects a breakfast item that is on the list.
2. If the item does not exist throw an exception.
3. Asks user to input a number.
4. Validates the number.
5. If the number the user inputs is not valid go to step 3.
6. If the number the user inputs is valid return the price of the user's choice. 

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call: 

My first test is to call the method with a list containing 0 elements.

Second call: 

My second test is to call the method with a list containing 5 items. 

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call: This tests that my method validates an invalid input properly. 
 

Condition(s) tested by the second call:

This tests that the method runs when the input is not invalid. 

### 3d iii.

Result of the first call:

The result of this call would be the program would throw an exception. 

Result of the second call:

The result of this call would be a message asking the user to enter a number, then returning the price of the breakfast item that corresponds with the number the user inputted. 