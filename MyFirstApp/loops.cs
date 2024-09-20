

class Loops
{
    public static void ForLoops()
    {
        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Iteration: " + i);
        }
    }
    public static void EvenLoop()
    {
        for(int i = 1; i <= 20; i++)
        {
            Console.WriteLine();
        }
    }
    public static void NestedLoops()
    {
        for(int i = 0; i <= 3; i++)
        {
            Console.WriteLine("Iteration i: " + i);
            for(int j = 0; j <= 3; j++)
            {
                Console.WriteLine("             Iteration j: " + j);
            }
        }
    }
}