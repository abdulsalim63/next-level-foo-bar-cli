using System.Text;

namespace CodeCompetencyTest
{
  public class FooBarSeven : IFooBar
  {
    public void Run(int n)
    {
      for (int i=1; i<=n; i++)
      {
        var str = new StringBuilder();

        if (i % 3 == 0) str.Append("foo");
        if (i % 5 == 0) str.Append("bar");
        if (i % 7 == 0) str.Append("jazz");

        if (str.Length > 0) Console.Write(str.Append(' ').ToString());
        else Console.Write(i + " ");

        if (i % 20 == 0) Console.Write("\n");
      }
    }
  }
}