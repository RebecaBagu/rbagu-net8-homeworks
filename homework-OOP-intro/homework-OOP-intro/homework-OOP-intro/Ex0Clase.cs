public class Game
{
    string name;
    string developer;
    DateOnly release;
    string genre;
    public Game(string name, string developer, DateOnly release, string genre)
    {
        this.name = name;
        this.developer = developer;
        this.release = release;
        this.genre = genre;
    }
    public string GetName()
    {
        return name;
    }
    public string GetDeveloper()
    {
        return developer;
    }
    public DateOnly GetRelease()
    {
        return release;
    }
    public string GetGenre()
    {
        return genre;
    }
    public void SetName(string name)
    {
        this.name=name;
    }
    public void SetDeveloper(string developer)
    {
        this.developer=developer;
    }
    public void SetRelease(DateOnly release)
    {
        this.release= release;
    }
    public void SetGenre(string genre)
    {
        this.genre=genre;
    }
}

