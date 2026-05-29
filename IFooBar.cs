namespace CodeCompetencyTest
{
  public interface IFooBar
  {
    void Run(int n);
    bool AddRule(int input, string output, bool verify = false) => false;
    bool RemoveRule(int input, bool verify = false) => false;
  }
}