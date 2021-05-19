using System;

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
                Console.WriteLine("10. Are these Names the Same?");
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
            // Ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here

            Console.WriteLine("enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if(firstNumber == secondNumber)
            {
                Console.WriteLine("These numbers are equal");
            }
            else
            {
                Console.WriteLine("These numbers are Not equal");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void EvenOrOdd()
        {
            // Ask the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here

            Console.WriteLine("Enter Number");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            int result = userNumber % 2;

            if(result == 0)
            {
                Console.WriteLine("This number is Even!");
            }
            else
            {
                Console.WriteLine("This number is Odd!");
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void VowelOrConsonant()
        {
            // Ask the user for a letter. Check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here

            Console.WriteLine("Enter A Letter");
            string inputLetter = Console.ReadLine();

            if (inputLetter == "a" || inputLetter == "e" || inputLetter == "i" || inputLetter == "o" || inputLetter == "u")
            {
                Console.WriteLine("this is a Vowel");
            }
            else
            {
                Console.WriteLine("this ia a consonant");
            }    

            

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void FindLargestNumber()
        {
            // Prompt the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here

            Console.WriteLine("Enter First Number");
            int firstValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int secondValue = Convert.ToInt32(Console.ReadLine());



            if (firstValue < secondValue)
            {
                Console.WriteLine("Second Value is Largest!");
            }
            else if (firstValue > secondValue)
            {
                Console.WriteLine("First value is Largest!");
            }
            else
            {
                Console.WriteLine("Values are equal");
            } 



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here

            Console.WriteLine("enter Number");
            int userNumb = Convert.ToInt32(Console.ReadLine());

            int result = userNumb % 3;

            if (result == 0)
            {
                Console.WriteLine("This number is divisible by 3!");

            }
            else
            {
                Console.WriteLine("This number isn Not divided by 3.");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void RestaurantBill()
        {
            // At a restaurant, Mike and his three friends decided to divide the bill evenly.
            // If each person paid $13 then what was the total bill?
            // Use arithmetic operators and print the amount of the total bill to the console.

            // Returning to the above problem, replace hard-coded values of 4(number of diners)
            // and 13(cost per diner) with values provided by the user.

            // How nice!The restaurant is having Customer Appreciation Week.
            // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
            // Otherwise, they’ll receive a 5 % discount.

            Console.Clear();
            Console.WriteLine("RESTAURANT BILL\n");

            // Enter your solution here
            Console.WriteLine("how many diners?");
            int diners = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("how much did each diner spend?");
            int costPerDiner = Convert.ToInt32(Console.ReadLine());


           double total = diners * costPerDiner;

            if(total >= 50)
            {
                total = total - (total * .10);
            }
            else
            {
                total = total - (total * .05);
            }

            Console.WriteLine(total);


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
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());


            // && means AND
            // || means OR
           

            if (age >=0 && age <= 2)
            {  
                Console.WriteLine("Still in mama's arms");
                }
            else if(age == 3 || age == 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if(age > 4 && age < 12)
            {
                Console.WriteLine("Elementary School");
            }
            else if(age > 11 && age < 15)
            {
                Console.WriteLine("Middle School");
            }
            else if(age > 14 && age < 19)
            {
                Console.WriteLine("High School");
            }
            else if(age > 18 && age < 20)
            {
                Console.WriteLine("College");
            }
            else if(age > 22 && age < 66)
            {
                Console.WriteLine("Working for the Man");
            }
            else if(age > 65 && age < 101)
            {
                Console.WriteLine("Golden Years");
            }
            else if(age < 0 || age > 100)
            {
                Console.WriteLine("This Program is for Humans");
            }
            
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
            Console.WriteLine("Enter Number from Zero to Ten");
            string userInput = Console.ReadLine();

            switch (userInput)
            {




                case "zero":
                    Console.WriteLine(0);
                    break;
                case "one":
                    Console.WriteLine(1);
                    break;
                case "two":
                    Console.WriteLine(2);
                    break;
                case "three":
                    Console.WriteLine(3);
                    break;
                case "four":
                    Console.WriteLine(4);
                    break;
                case "five":
                    Console.WriteLine(5);
                    break;
                case "six":
                    Console.WriteLine(6);
                    break;
                case "seven":
                    Console.WriteLine(7);
                    break;
                case "eight":
                    Console.WriteLine(8);
                    break;
                case "nine":
                    Console.WriteLine(9);
                    break;
                case "ten":
                    Console.WriteLine(10);
                    break;

                    Console.ReadLine();

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

            Console.WriteLine("First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine(firstName + " " + lastName);


            if(firstName.Length > lastName.Length)
            {
                Console.WriteLine("First is Longer");
            }
           else if(firstName.Length == lastName.Length)
            {
                Console.WriteLine("Same-sies!");
            }
            else
            {
                Console.WriteLine("Last must be longer");
            }

            

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

            Console.WriteLine("Enter Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Name");
            string secondName = Console.ReadLine();


            if(firstName == secondName)
            {
                Console.WriteLine("The names are the same");
            }
            else
            {
                Console.WriteLine("The names are different");
            }


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

            Console.WriteLine("First Name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("Palce of Birth?");
            string birthPlace = Console.ReadLine();

            Console.WriteLine("Your name is " + firstName + " and your were Born in " + birthPlace + ".");


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}
