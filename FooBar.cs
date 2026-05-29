using System.Text;

namespace CodeCompetencyTest
{
  public class FooBar : IFooBar
  {
    private Dictionary<int, string> Divisible { get; set; }

    public FooBar()
    {
      Divisible = new()
      {
        { 3, "foo" },
        { 4, "baz" },
        { 5, "bar" },
        { 7, "jazz" },
        { 9, "huzz"}
      };
    }

    public bool AddRule(int input, string output, bool verify = false)
    {
      if (Divisible.ContainsKey(input) && !verify)
      {
        Console.WriteLine($"Warning: Existing divisible key {input}. Would you like to replace the output? (y/n)");
        return false;
      }

      if (Divisible.ContainsValue(output) && !verify)
      {
        Console.WriteLine($"Warning: Existing divisible value {output}. Output might be confusing.");
        Console.WriteLine("Would you like to proceed? (y/n)");
        return false;
      }

      if (Divisible.ContainsKey(input))
      {
        Divisible[input] = output;
      }
      else
      {
        Divisible.Add(input, output);
      }
      Divisible = Divisible.OrderBy(d => d.Key).ToDictionary();

      return true;
    }
    
    public bool RemoveRule(int input, string output, bool verify = false)
    {
      if (Divisible.ContainsKey(input) && !verify)
      {
        Console.WriteLine($"Warning: Existing divisible key {input}. Would you like to replace the output?");
        return false;
      }

      if (Divisible.ContainsValue(output) && !verify)
      {
        Console.WriteLine($"Warning: Existing divisible value {output}. Output might be confusing.");
        return false;
      }

      if (Divisible.ContainsKey(input))
      {
        Divisible[input] = output;
      }
      else
      {
        Divisible.Add(input, output);
      }
      Divisible = Divisible.OrderBy(d => d.Key).ToDictionary();

      return true;
    }
    
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