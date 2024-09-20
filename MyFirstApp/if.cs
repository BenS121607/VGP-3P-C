

using System.Globalization;

class If
{
    public static void IfElse(int number)
    {

        if(number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if(number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("Your number is zero.");
        }
    }
    public static void IfHealth(int health)
    {
        if(health > 75)
        {
            Console.WriteLine("The player's health is in great condition: " + health);
        }
        else if(health > 50)
        {
            Console.WriteLine("The player's health is in good condition: " + health);
        }
        else if(health > 0)
        {
            Console.WriteLine("The player's health is in danger: " + health);
        }
        else
        {
            Console.WriteLine("GAME OVER... " + health);
        }
    }
}