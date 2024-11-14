namespace NModels;

public abstract class NProfile(string name, string url, DateOnly dob)
{
  public string Name { get; set; } = name;
  public string Url { get; } = url;
  public DateOnly Dob { get; } = dob;

  private string hostname = new Uri(url).Host;

  public abstract List<string> GetAlbums();

  public List<ProfileRanks> Ranks = new();

}

public class Profile(string name, string url, DateOnly dob) : NProfile(name, url, dob)
{

  public override List<string> GetAlbums()
  {
    return [];
  }

}

public class ProfileRanks(int rank, DateTime date)
{
  public int Rank = rank;
  public DateTime Date = date;

}