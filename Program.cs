namespace Basic_Week_One;

class Program
{
    static void Main(string[] args)
    {
        /*
            Classes & Objects
        */

        // this example, instanciates the object and fills in the field values directly
        string string1 = "Hello";
        string string2 = "World";


        if (string1.GetType() == string2.GetType())
        {
            Console.WriteLine($"these two are both valid {string1.GetType()} == {string2.GetType()} and equal datatypes ({string1.GetType()}).");
        }
        else
        {
            Console.WriteLine("These two objects/classes are not equal.");
        }

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

        if (john.GetType() == jane.GetType())
        {
            Console.WriteLine($"{john.GetType()} & {jane.GetType()} are equal objects/classes/datatypes");
        }


        // these two examples, uses the primary constructor, and passes the values from the constructor to the fields rather than declaring the fields directly, they get their arguments from the constructor.
        var dale = new Person("Dale Cooper", 34, "FBI agent", ["Meditation", "Drinking coffee", "Exploring the occult"]);

        var tony = new Person("Tony Soprano", 42, "Mob boss", ["Drinking", "Gambling", "Extorsion", "Making others miserable"]);

        Person mcnulty = new Person("Jimmy Mcnulty", 38, "Police Detective", ["Drinking", "Solving crimes"]);

        List<Person> people = new List<Person>()
        {
            john,
            jane,
            dale,
            tony,
            mcnulty,
            new Person("SSA Gordon", 53, "Supervisory Special Agent", ["Mysticism", "The occult", "Advocating for the rights of the hearing impaired"])
        };

        foreach (var p in people)
        {
            p.PrintInformationAboutAPerson();
        }


        var tonyHawksProSkater = new VideoGames
        {
            Title = "Tony Hawk's Pro Skater 4",
            ReleaseYear = 2002,
            Platform = "Playstation 2",
            HasOnlineMultiplayer = false,
            Studio = "Neversoft",
            Price = 500
        };

        List<VideoGames> videoGames = new List<VideoGames>()
        {
            tonyHawksProSkater,
            new VideoGames("Tekken", 1994, "Arcade/Playstation 1", false, "Bandai Namco", 0),
            new VideoGames("Metal Gear Solid", 1998, "Playstation", false, "Konami", 350),
        };


        foreach (var game in videoGames)
        {
            game.PrintGameInfo();
        }

        // Static vs "dynamic" classes 
        Console.WriteLine($"Fahrenheit degrees {32} {TemperatureConverter.ConvertToCelsius(32)})");

        double fahrenheit = TemperatureConverter.ConvertToFahrenheit(0);
        Console.WriteLine(fahrenheit);

        /*
            User input using the Console class
        */

        // Console.WriteLine("Hello, what is your name? ");
        // var name = Console.ReadLine();
        // Console.WriteLine("How old are you? ");
        // var ageInput = Console.ReadLine();
        // //var age = int.Parse(ageInput!);
        // int.TryParse(ageInput, out int age);


        // var userInputPerson = new Person(name!, age, "", ["", ""]);
        // userInputPerson.PrintInformationAboutAPerson();


        var calculator = new Calculator();

        calculator.Xvalue = 25;
        calculator.YValue = 10;

        var sum = calculator.AddNumbers(10, 5);
        Console.WriteLine(sum);
        calculator.SubtractNumbers(50, 25);

        calculator.PrintXandY();


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

        // void ExampleOne()
        // {
        //     Console.WriteLine("Example one!");
        // }

        // ExampleOne();
        // ExampleTwo();

    }
    // static void ExampleTwo()
    // {
    //     Console.WriteLine("Example two!");
    // }
}