using System;

namespace First_Project_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //STRING VARIABLES AND MANIPULATION (Strings, Numbers and Dates)

            //Exercise 1
            string askMessage = "What is your full name?"; 
            Console.WriteLine(askMessage); 
            string responseFullName = Console.ReadLine(); 
            Console.WriteLine($"So your name is... \n {responseFullName.ToUpper().TrimEnd()}");
            Console.WriteLine($"{responseFullName.ToLower().TrimStart()}");
            Console.WriteLine($"With a length of {responseFullName.Trim().Length} characters.");

            // display location of first and last space in name ? Initials? Index of first and last character? 
            // Console.WriteLine($"");


            //Exercise 2
            askMessage = "What is your social security number?";
            Console.WriteLine(askMessage);
            string responseSocialNumber = Console.ReadLine().Trim();
            Console.WriteLine($"So the first number of your social security number is {responseSocialNumber[0]}");
            int lastFourIndex = responseSocialNumber.Length - 4;
            Console.WriteLine($"And the last 4 numbers of your social security number are {responseSocialNumber.Substring(lastFourIndex)}");
            string starredNumber = responseSocialNumber.Replace("-", "");
            int socialLength = starredNumber.Length;
            string stars = new String('*', (socialLength-4));
            starredNumber = stars + responseSocialNumber.Substring(lastFourIndex); 
            Console.WriteLine($"And THIS is your SSN with some neat stars... {starredNumber}");


            //Exercise 3
            askMessage = "Now we are going to create a password. Enter in any phrase to start.";
            Console.WriteLine(askMessage);
            string userPhrase = Console.ReadLine();
            Console.WriteLine("Now enter any number greater than 9.");
            string userNumber = Console.ReadLine();
            userPhrase = (userPhrase.Replace(" ", "").Replace("a", "2").Replace("o", "0").Replace("i", "!"));
            string userPassword = userNumber[userNumber.Length-1] + userPhrase + userNumber[0];
            Console.WriteLine($"Your new password is {userPassword}. Congrats!");

        }
    }
}
