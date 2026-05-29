using System.Security.Cryptography;

namespace CodeCompetencyTest
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to foo bar CLI!!");
      Console.WriteLine(@"There are 4 fooBar function you can try
      (1) Simple foo bar, 3: foo and 5: bar
      (2) Foo bar seven with addition, 7: jazz
      (3) Foo bar extended, with addition 4: baz and 9: huzz
      (4) Complete foo bar, you can add or remove your own rules!
      ");
      
      IFooBar fooBar = null;
      while (fooBar == null)
      {
        Console.WriteLine("Input which function to try 1/2/3/4");
        var app = Console.ReadLine();
        try
        {
          switch(Convert.ToInt32(app))
          {
            case 1:
              fooBar = new SimpleFooBar();
              break;
            case 2:
              fooBar = new FooBarSeven();
              break;
            case 3:
              fooBar = new FooBarExtended();
              break;
            case 4:
              fooBar = new FooBar();

              Console.WriteLine("You can add rule or skip. ('3:foo'/n)");
              var answer = Console.ReadLine();
              if (answer.Equals("n")) continue;
              else
              {
                var splitAns = answer.Split(":");
                var addRule = fooBar.AddRule(Convert.ToInt32(splitAns[0]), splitAns[1]);
                if (!addRule)
                {
                  answer = Console.ReadLine();
                  if (answer.Equals("n")) continue;
                  else if (answer.Equals("y"))
                  {
                    fooBar.AddRule(Convert.ToInt32(splitAns[0]), splitAns[1], true);
                  }
                }
              }
              break;
            default:
              Console.WriteLine("Wrong Input");
              break;
          }
        }
        catch (FormatException)
        {
          Console.WriteLine("Invalid Input");
        }
        catch (Exception e)
        {
          Console.WriteLine("There's something wrong");
          Console.WriteLine(e.ToString());
        }
      }
      
      while (true)
      {
        Console.WriteLine("\nInput n to print the foo bar");
        var n = Console.ReadLine();
        fooBar.Run(Convert.ToInt32(n));
      }
    }
  }
}
