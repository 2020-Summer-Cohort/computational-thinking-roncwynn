﻿using System;
using System.Collections.Concurrent;

namespace ComputationalThinkingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("COMPUTATIONAL THINKING EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Are These Integers Equal?");
                Console.WriteLine("2. Even or Odd?");
                Console.WriteLine("3. Vowel or Consonant?");
                Console.WriteLine("4. Find the Largest Number");
                Console.WriteLine("5. Divisible by 3");
                Console.WriteLine("6. Restaurant Bill");
                Console.WriteLine("7. Age Category");
                Console.WriteLine("8. Words to Digits");
                Console.WriteLine("9. Which Name is Longer?");
                Console.WriteLine("10. Are these Numbers the Same?");
                Console.WriteLine("11. Name and Place of Birth");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch(userChoice)
                {
                    case "1":
                        AreTheseIntegersEqual();
                        break;
                    case "2":
                        EvenOrOdd();
                        break;
                    case "3":
                        VowelOrConsonant();
                        break;
                    case "4":
                        FindLargestNumber();
                        break;
                    case "5":
                        DivisibleBy3();
                        break;
                    case "6":
                        RestaurantBill();
                        break;
                    case "7":
                        AgeCategory();
                        break;
                    case "8":
                        WordsToDigits();
                        break;
                    case "9":
                        WhichNameIsLonger();
                        break;
                    case "10":
                        AreNamesSame();
                        break;
                    case "11":
                        NameAndBirthplace();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void AreTheseIntegersEqual()
        {
            // Write a console application to ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here
            string inputOne, inputTwo;

            Console.WriteLine("Input First Number:");
            inputOne = Console.ReadLine();
            Console.WriteLine("Input Second Number:");
            inputTwo = Console.ReadLine();
            Console.WriteLine();

            if (inputOne == inputTwo)
            { Console.WriteLine($"The numbers  {inputOne} and {inputTwo} are the same number"); }
            else { Console.WriteLine($"The numbers {inputOne} and {inputTwo} are not equal to each other"); }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void EvenOrOdd()
        {
            // Write a console application that asks the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here

            Console.WriteLine("Input a Number:");
            double inputOneDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (inputOneDouble % 2 == 0)
            { Console.WriteLine($"{inputOneDouble} is an EVEN number"); }
            else
            { Console.WriteLine($"{inputOneDouble} is an ODD number"); }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void VowelOrConsonant()
        {
            // Write a console application to check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here

            string vowels = "aeiou";

            Console.WriteLine("Please enter a letter");
            char userInput = Convert.ToChar(Console.ReadKey().KeyChar);
            char letter = Char.ToLower(userInput);
            Console.WriteLine();
            
            if (vowels.Contains(letter))
            { Console.WriteLine($"{userInput} is a VOWEL"); }
            else
            { Console.WriteLine($"{userInput} is a CONSONANT"); }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void FindLargestNumber()
        {
            // Write a console application that prompts the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here

            //string userInputOne, userInputTwo;

            Console.WriteLine("Input First Number:");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Second Number:");
            int inputTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (inputOne == inputTwo)
            { Console.WriteLine($"The two values, {inputOne} and {inputTwo} are EQUAL"); }
            else if (inputOne > inputTwo)
            { Console.WriteLine($"{inputOne} is the larger number"); }
            else { Console.WriteLine($"{inputTwo} is the larger number"); }

            Console.WriteLine("Input a Third Number:");
            int inputThree = Convert.ToInt32(Console.ReadLine());

            if (inputOne > inputTwo && inputOne > inputThree) { Console.WriteLine($"{inputOne} is the largest."); }
            else if (inputTwo > inputOne && inputTwo > inputThree) { Console.WriteLine($"{inputTwo} is the largest."); }
            else { Console.WriteLine($"{inputThree} is the largest."); }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here

            Console.WriteLine("Input a Number:");
            double inputOneDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (inputOneDouble%3==0)
            { Console.WriteLine($"{inputOneDouble} IS divisible by 3"); }
            else { Console.WriteLine($"{inputOneDouble} IS NOT divisible by 3"); }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void RestaurantBill()
        {
            // At a restaurant, Mike and his three friends decided to divide the bill evenly.
            // If each person paid $13 then what was the total bill?

            // Returning to the above problem, replace hard-coded values of 4(number of diners)
            // and 13(cost per diner) with values provided by the user.
            
            // How nice!The restaurant is having Customer Appreciation Week.
            // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
            // Otherwise, they’ll receive a 5 % discount.

            Console.Clear();
            Console.WriteLine("RESTAURANT BILL\n");

            // Enter your solution here

            Console.WriteLine("How many diners in the party?");
            decimal numberOfDiners = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("What is the total bill amount?");
            decimal totalBill = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();
            
            decimal costPerDiner = totalBill / numberOfDiners;

            if (totalBill >= 50)
            { 
                Console.WriteLine("Congrats, you receive a 10% discount for a total bill amount greater than $50");
                Console.WriteLine($"Each person owes ${(costPerDiner*.9m).ToString("C2")}.");
            }
            else { Console.WriteLine($"Each person owes ${(costPerDiner * .95m).ToString("C2")}."); }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AgeCategory()
        {
            // You're responsible for providing a demographic report for your local school district based on age.
            // To do this, you're going to determine which 'category' each person fits into based on their age.
            // The person's age will determine which category they should be in:

            // If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
            // If they're 3 or 4 and should be in preschool print : 'Preschool Maniac'
            // If they're from 5 to 11 and should be in elementary school print : 'Elementary School'
            // From 12 to 14: 'Middle School'
            // From 15 to 18: 'High School'
            // From 19 to 22: 'College'
            // From 23 to 65: 'Working for the Man'
            // From 66 to 100: 'The Golden Years'
            // If the age of the person is less than 0 or more than 100 - it might be an alien
                    // print: "This program is for humans".

            Console.Clear();
            Console.WriteLine("AGE CATEGORY\n");

            // Enter your solution here

            Console.WriteLine("Enter the students age:");
            int personAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (0 <= personAge && personAge <= 2) { Console.WriteLine("Still in Mama's Arms"); }
            else if (personAge == 3 || personAge == 4) { Console.WriteLine("Preschool Maniac"); }
            else if (5 <= personAge && personAge <= 11) { Console.WriteLine("Elementary School"); }
            else if (12 <= personAge && personAge <= 14) { Console.WriteLine("Middle School"); }
            else if (15 <= personAge && personAge <= 18) { Console.WriteLine("High School"); }
            else if (19 <= personAge && personAge <= 22) { Console.WriteLine("College"); }
            else if (23 <= personAge && personAge <= 65) { Console.WriteLine("Working for the Man"); }
            else if (66 <= personAge && personAge <= 100) { Console.WriteLine("The Golden Years"); }
            else { Console.WriteLine("This program is for humans"); }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");

            // Enter your solution here

            Console.WriteLine("Please enter a number in STRING format from ZERO to TEN.");
            string someNumberString =  Console.ReadLine().ToLower();

            switch (someNumberString)
            {
                case "zero":
                    {
                        Console.WriteLine("0");
                        break;
                    }
                case "one":
                    {
                        Console.WriteLine("1");
                        break;
                    }
                case "two":
                    {
                        Console.WriteLine("2");
                        break;
                    }
                case "three":
                    {
                        Console.WriteLine("3");
                        break;
                    }
                case "four":
                    {
                        Console.WriteLine("4");
                        break;
                    }
                case "five":
                    {
                        Console.WriteLine("5");
                        break;
                    }
                case "six":
                    {
                        Console.WriteLine("6");
                        break;
                    }
                case "seven":
                    {
                        Console.WriteLine("7");
                        break;
                    }
                case "eight":
                    {
                        Console.WriteLine("8");
                        break;
                    }
                case "nine":
                    {
                        Console.WriteLine("9");
                        break;
                    }
                case "ten":
                    {
                        Console.WriteLine("10");
                        break;
                    }
                 default:
                    {
                        Console.WriteLine("Invalild Input");
                        break;
                    }
                    
            }
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.

            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"

            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            // Enter your solution here

            //string firstName, lastName;

            Console.WriteLine("Enter your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine();
            string message = firstName + " " + lastName + ".  ";
            Console.WriteLine(message);

            if (firstName.Length > lastName.Length) { Console.WriteLine(message + "First is longer."); }
            else if (firstName.Length == lastName.Length) { Console.WriteLine(message + "Same-sies."); }
            else { Console.WriteLine(message + "Last must be longer."); }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            // Enter your solution here

            Console.WriteLine("Enter a name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter another name:");
            string secondName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("First way using ==");
            if (firstName.ToLower() == secondName.ToLower()) { Console.WriteLine("The names are the same."); }
            else { Console.WriteLine("The names are different."); }

            Console.WriteLine();
            Console.WriteLine("Second way using .Equals");
            if (firstName.ToLower().Equals(secondName.ToLower())) { Console.WriteLine("The names are the same."); }
            else { Console.WriteLine("The names are different."); }
            Console.WriteLine();

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            // Enter your solution here

            Console.WriteLine("Please enter your First name:");
            string firstName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Where were you born?");
            string placeOfBirth = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Hi {firstName}.  You were born in {placeOfBirth}.");
            Console.WriteLine();

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}
