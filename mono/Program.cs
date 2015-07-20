using System;
//gmcs Program.cs 
//mono Program.exe

namespace ConsoleApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Shape sh = new Shape();

      sh.Colour = "blue";

      Console.WriteLine(sh.Colour);

      Console.ReadLine();

    }
  }


  public class Shape
  {
    public string Colour;

  }


}
