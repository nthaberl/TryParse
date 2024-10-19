/********************************************************************* 
*    Course:     DEV 110 
*    Instructor: Phil Duncan
*    Term:       Fall 2024
*
*    Programmer: NataschaHaberl
*    Assignment: TryParseTimedExercise
*    
*    Description:   
*    A 30 minute exercise to complete a number validation with TryParse() and while loop
*    
* 
*    Revision    Date               Release Comment 
*    --------     ----------        ------------------------------------------------------ 
*    1.0         10/18/2024         Initial Release 
*    
* 
*/

using System;
using static System.Console;

namespace TryParseTimedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double validDouble = 0;
            bool numberIsValid;
            int attempts = 1;

            Write("Enter a number: ");
            numberIsValid = double.TryParse(userInput = ReadLine(), out validDouble);

            while (!numberIsValid)
            {
                attempts++;
                WriteLine($"You know that's not a number, please enter an actual number.");
                numberIsValid = double.TryParse(userInput = ReadLine(), out validDouble);
            }

            if (numberIsValid == true)
            {
                if (attempts == 1)
                {
                    WriteLine($"Congrats! {userInput} is a valid number, and it only took you {attempts} try!");
                }
                else
                {
                    WriteLine($"Congrats! {userInput} is a valid number, it only took you {attempts} tries!");
                }
            }
        }
    }
}