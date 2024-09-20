

class Lists
{
    public static void list1()
    {
        List<string> fruit = new List<string>();

        fruit.Add("Apple");
        fruit.Add("Banana");
        fruit.Add("Grape");
        fruit.Add("Cucumber");
        fruit.Add("Orange");

        Console.WriteLine("There are " + fruit.Count + " fruits in this list. They are as follows:");

        foreach (string fruits in fruit)
        {
            Console.WriteLine(fruits);
        }

        fruit.RemoveAt(3);

        Console.WriteLine("Never mind. There are " + fruit.Count + " fruits in this list. They are as follows:");

        foreach (string fruits in fruit)
        {
            Console.WriteLine(fruits);
        }
    }
}