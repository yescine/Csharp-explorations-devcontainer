// namespace SyntaxSpace;

public class Syntax(string name, int? batch = null)
{
  public string Name { get; } = name.Replace("s", "");
  public bool IsPlural { get; } = name.Contains('s');
  public int Batch { get; } = batch ?? 5; // Set default value of 5 if batch is null

  private List<char> Process { get; } = ['A', 'C', 'R', 'X', 'Y'];

  public bool TestLoop()
  {
    var result = true;
    bool cond = Process.Count > 2 && IsPlural;
    if (cond) result = !IsPlural;
    return result;
  }

  public void PrintBatch()
  {
    Console.WriteLine($"last index: {Process[^1]}");
    foreach (var idx in Process[1..3])
    {
      Console.WriteLine($"idx: {idx}");
    }
  }

  public void Linq()
  {
    int[] scores = { 97, 92, 81, 60, 44, 99, 20, 120 };
    var minScore = 80;
    IEnumerable<int> scoreQuery =
      from score in scores
      where score > minScore && score < 100
      orderby score ascending
      select score;
    Console.WriteLine($"\nLinq list {string.Join(" | ", scoreQuery)} with total ");
  }

}
