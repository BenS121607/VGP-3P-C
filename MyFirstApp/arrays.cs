

using System.ComponentModel.DataAnnotations;

class Arrays
{

    public static void Array1(String[] args)
    {
        int[] number = new int[5];
        number[0] = 1;

        Console.WriteLine(number[0]);

        string[] names = {"Alice", "Bob", "Charlie"};
        Console.WriteLine(names[0]);

        int[] grades = new int[5];
        grades[0] = 85;
        grades[1] = 90;
        grades[2] = 78;
        grades[3] = 92;
        grades[4] = 88;

        Console.WriteLine("Grades: ");
        for(int i = 0; i < grades.Length; i ++)
        {
            Console.WriteLine(grades[1]);
        }
    }
}