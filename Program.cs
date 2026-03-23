namespace Basic_Week_One;

class Program
{
    static void Main(string[] args)
    {
        /*
            Explicit type casting/assignment

            we set a value to a given datatype and name that "variable" a fitting name that corresponds to its usecase.
        */
        string hellWorld = "Hello, World";
        int num1 = 10;
        double num2 = 25;
        float floatNum = 25f;
        bool isTrue = true;
        char a = 'a';
        char and = '&';
        Console.WriteLine(hellWorld + "!");
        Console.WriteLine(num1 + num2 + floatNum);
        Console.WriteLine(isTrue);
        Console.WriteLine(a + and);
        // ascii verdi for 'a' = 97, ascii verdi for 'b' = 98. -> 97 + 98 = 195

        /*
            Implicit type casting when assigning variables
        */
        var myText = "Hello C#!";
        var num3 = 25.25;
        Console.WriteLine(myText);
        Console.WriteLine(num3);

        /*
            Data structures/Collections
        */
        string[] shoppingItems = { "Milk", "Soda", "Beef", "Chicken" };
        Console.WriteLine(shoppingItems.Length);
        // List data structure
        List<string> shoppingList = new List<string>();
        // add the current items from the array to the list
        shoppingList.AddRange(shoppingItems);
        shoppingList.AddRange(["Candy", "Cheese", "Juice", "Paper towels", "Gravy"]);

        // regular for-loop
        for (int i = 0; i < shoppingItems.Length; i++)
        {
            Console.WriteLine(shoppingItems[i]);
        }

        Console.WriteLine("@@@@@@@@@@@@@@@@@@@");

        // foreach loop
        foreach (var items in shoppingList)
        {
            Console.WriteLine(items);
        }

        Console.WriteLine(shoppingList.Count);

        // this represents a 5x5 grid

        // int[] rows = [1, 2, 3, 4, 5];
        // int[] colums = [1, 2, 3, 4, 5];
        Console.WriteLine("@@@@@@@@@@@@@@@@@@");

        var capitalCities = new Dictionary<string, string>()
        {
             {"Norway", "Oslo"},
             {"Sweden", "Stockholm"},
             {"Denmark", "Copenhagen"},
             {"Japan", "Tokyo"}
        };

        var germany = "Germany";
        var germanCapital = "Berlin";
        capitalCities[germany] = germanCapital;

        capitalCities.Add("China", "Beijing");

        foreach (var capital in capitalCities)
        {
            Console.WriteLine(capital);
        }

        var grades = new Dictionary<string, string>();
        grades.Add("Student1", "A");
        grades.Add("Studen2", "D");
        grades.Add("Student3", "B");

        foreach (var grade in grades)
        {
            Console.WriteLine(grade);
        }

    }
}