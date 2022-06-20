// See https://aka.ms/new-console-template for more information
namespace dotnet__poo
{

using C.src.Entities;



class Program
{

  static void Main(string[] args)
  {
    Hero hero = new Hero("Hulk", 30, "Monster");

    Wizard wizard = new Wizard("Strange", 50, "Wizard");


      Console.WriteLine(hero.ToString());
      Console.WriteLine(hero.Attack());
      Console.WriteLine(wizard.ToString());
      Console.WriteLine(wizard.Attack(7));
  }
}


}