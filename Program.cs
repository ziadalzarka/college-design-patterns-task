using System;

namespace design_patterns
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("1- Proxy Design Pattern");
      Console.WriteLine("------------------------");
      ProxyPattern.Program.Main();

      Console.WriteLine("");
      Console.WriteLine("**************************************");
      Console.WriteLine("");

      Console.WriteLine("2- Facade Design Pattern");
      Console.WriteLine("------------------------");
      FacadePattern.Program.Main();

      Console.WriteLine("");
      Console.WriteLine("**************************************");
      Console.WriteLine("");

      Console.WriteLine("3- Observer Design Pattern");
      Console.WriteLine("------------------------");
      ObserverPattern.Program.Main();

      Console.WriteLine("");
      Console.WriteLine("**************************************");
      Console.WriteLine("");

      Console.WriteLine("4- Adapter Design Pattern");
      Console.WriteLine("------------------------");
      AdapterPattern.Program.Main();
    }
  }
}
