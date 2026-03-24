public class VideoGames
{
    public string? Title;
    public int ReleaseYear;
    public string? Platform;
    public bool HasOnlineMultiplayer;
    public string? Studio;
    public double Price;

    public VideoGames()
    {

    }

    public VideoGames(string title, int releaseYear, string platform, bool hasOnlineMultiplayer, string studio, double price)
    {
        Title = title;
        ReleaseYear = releaseYear;
        Platform = platform;
        HasOnlineMultiplayer = hasOnlineMultiplayer;
        Studio = studio;
        Price = price;
    }

    public void PrintGameInfo()
    {
        Console.WriteLine($"Title: {Title} release year: {ReleaseYear} platform: {Platform} has online multiplayer: {HasOnlineMultiplayer} studio: {Studio} price: {Price:C}");
    }
}