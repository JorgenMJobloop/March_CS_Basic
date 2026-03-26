public class Person
{
    public string? Name;
    public int Age;
    public string? Occupation;
    public List<string> Hobbies = new List<string>();

    /// <summary>
    /// constructor
    /// </summary>
    public Person()
    {

    }

    /// <summary>
    /// this constructor is being overloaded, and allows for four parameter arguments that is passed directly to this class's fields
    /// </summary>
    /// <param name="name">name of the person</param>
    /// <param name="age">a persons age</param>
    /// <param name="occupation">a persons occupation</param>
    /// <param name="hobbies">a list of a persons hobbies (can be empty)</param>
    public Person(string name, int age, string occupation, List<string> hobbies)
    {
        Name = name;
        Age = age;
        Occupation = occupation;
        Hobbies = hobbies;
    }

    public void PrintInformationAboutAPerson()
    {
        Console.WriteLine($"Persons name: {Name}, persons age: {Age}, occupation: {Occupation}, hobbies: {string.Join(", ", Hobbies)}");
    }

    /// <summary>
    /// Get the name of a person given by it's object declaration
    /// </summary>
    /// <returns>string</returns>
    public string GetAPersonsName()
    {
        return Name!;
    }

    public int GetAPersonsAge()
    {
        return Age;
    }

    public int NewGetAge() => Age;

    public int OldSwitchValidAge(int age)
    {
        switch (age)
        {
            case -1:
                Console.WriteLine("Cannot be less than 0 years old");
                break;
            case 125:
                Console.WriteLine("Cannot be older than 125");
                break;
        }
        return age;
    }

    public int ValidAge(int age) => age switch
    {
        0 => age > 0 ? 0 : throw new Exception(),
        125 => age <= 125 ? age : throw new Exception(),
        _ => age
    };
}