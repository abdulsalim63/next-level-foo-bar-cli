using System.Text;

namespace CodeCompetencyTest
{
  public class FooBarExtended : IFooBar
  {
    private readonly static Dictionary<int, string> Divisible = new()
    {
      { 3, "foo" },
      { 4, "baz" },
      { 5, "bar" },
      { 7, "jazz" },
      { 9, "huzz"}
    };
    
    public void Run(int n)
    {
      for (int i=1; i<=n; i++)
      {
        var str = new StringBuilder();

        foreach (var div in Divisible)
        {
          if (i % div.Key == 0) str.Append(div.Value);
        }

        if (str.Length > 0) Console.Write(str.Append(' ').ToString());
        else Console.Write(i + " ");

        if (i % 20 == 0) Console.Write("\n");
      }
    }
  }
}