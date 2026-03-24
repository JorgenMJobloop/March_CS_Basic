namespace Basic_Week_One;

class Program
{
    static void Main(string[] args)
    {
        /*
            Classes & Objects
        */

        // this example, instanciates the object and fills in the field values directly

        Person john = new Person
        {
            Name = "John Doe",
            Age = 35,
            Occupation = "Programmer",
            Hobbies = ["Programming", "Gaming"]
        };
        // this example like the one above it, also fills in the field values directly
        var jane = new Person
        {
            Name = "Jane Doe",
            Age = 33,
            Occupation = "Programmer",
            Hobbies = ["Programming", "Gaming", "Knitting"]
        };

        // these two examples, uses the primary constructor, and passes the values from the constructor to the fields rather than declaring the fields directly, they get their arguments from the constructor.
        var dale = new Person("Dale Cooper", 34, "FBI agent", ["Meditation", "Drinking coffee", "Exploring the occult"]);

        var tony = new Person("Tony Soprano", 42, "Mob boss", ["Drinking", "Gambling", "Extorsion", "Making others miserable"]);

        Person mcnulty = new Person("Jimmy Mcnulty", 38, "Police Detective", ["Drinking", "Solving crimes"]);

        john.PrintInformationAboutAPerson();

        jane.PrintInformationAboutAPerson();

        dale.PrintInformationAboutAPerson();

        tony.PrintInformationAboutAPerson();

        mcnulty.PrintInformationAboutAPerson();

        string name1 = mcnulty.GetAPersonsName();

        int age = tony.GetAPersonsAge();

        Console.WriteLine("Maritime " + name1);
        Console.WriteLine(age * 2);

        var tonyHawksProSkater = new VideoGames
        {
            Title = "Tony Hawks Pro Skater 4",
            ReleaseYear = 2002,
            Platform = "Playstation 2",
            HasOnlineMultiplayer = false,
            Studio = "Neversoft",
            Price = 500
        };

        tonyHawksProSkater.PrintGameInfo();


        /*
            Explicit type casting/assignment

            we set a value to a given datatype and name that "variable" a fitting name that corresponds to its usecase.
        */

        // string hellWorld = $"Hello, {dale.Name}";
        // int num1 = 10;
        // double num2 = 25;
        // float floatNum = 25f;
        // bool isTrue = true;
        // char a = 'a';
        // char and = '&';
        // Console.WriteLine(hellWorld + "!");
        // Console.WriteLine(num1 + num2 + floatNum);
        // Console.WriteLine(isTrue);
        // Console.WriteLine(a + and);
        // // ascii verdi for 'a' = 97, ascii verdi for 'b' = 98. -> 97 + 98 = 195

        // /*
        //     Implicit type casting when assigning variables
        // */
        // var myText = "Hello C#!";
        // var num3 = 25.25;
        // Console.WriteLine(myText);
        // Console.WriteLine(num3);

        // /*
        //     Data structures/Collections
        // */
        // string[] shoppingItems = { "Milk", "Soda", "Beef", "Chicken" };
        // Console.WriteLine(shoppingItems.Length);
        // // List data structure
        // List<string> shoppingList = new List<string>();
        // // add the current items from the array to the list
        // shoppingList.AddRange(shoppingItems);
        // shoppingList.AddRange(["Candy", "Cheese", "Juice", "Paper towels", "Gravy"]);

        // // regular for-loop
        // for (int i = 0; i < shoppingItems.Length; i++)
        // {
        //     Console.WriteLine(shoppingItems[i]);
        // }

        // Console.WriteLine("@@@@@@@@@@@@@@@@@@@");

        // // foreach loop
        // foreach (var items in shoppingList)
        // {
        //     Console.WriteLine(items);
        // }

        // Console.WriteLine(shoppingList.Count);

        // // this represents a 5x5 grid

        // // int[] rows = [1, 2, 3, 4, 5];
        // // int[] colums = [1, 2, 3, 4, 5];
        // Console.WriteLine("@@@@@@@@@@@@@@@@@@");

        // var capitalCities = new Dictionary<string, string>()
        // {
        //      {"Norway", "Oslo"},
        //      {"Sweden", "Stockholm"},
        //      {"Denmark", "Copenhagen"},
        //      {"Japan", "Tokyo"}
        // };

        // var germany = "Germany";
        // var germanCapital = "Berlin";
        // capitalCities[germany] = germanCapital;

        // capitalCities.Add("China", "Beijing");

        // foreach (var capital in capitalCities)
        // {
        //     Console.WriteLine(capital);
        // }

        // var grades = new Dictionary<string, string>();
        // grades.Add("Student1", "A");
        // grades.Add("Studen2", "D");
        // grades.Add("Student3", "B");

        // foreach (var grade in grades)
        // {
        //     Console.WriteLine(grade);
        // }

    }
}