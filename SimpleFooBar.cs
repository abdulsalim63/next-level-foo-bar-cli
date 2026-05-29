namespace CodeCompetencyTest
{
  public class SimpleFooBar : IFooBar
  {
    public void Run(int n)
    {
      for (int i=1; i<=n; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          Console.Write("foobar ");
        }
        else if (i % 5 == 0)
        {
          Console.Write("bar ");
        }
        else if (i % 3 == 0)
        {
          Console.Write("foo ");
        }
        else Console.Write(i + " ");

        if (i % 20 == 0) Console.Write("\n");
      }
    }
  }
}