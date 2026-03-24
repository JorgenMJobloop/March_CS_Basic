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
}