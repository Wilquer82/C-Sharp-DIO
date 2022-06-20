using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C.src.Entities
{
  public class Wizard : Hero
  {
    public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
    }
    public override string Attack()
    {
      return this.Name + " Lançou magia";
    }
    public string Attack(int Bonus){
      if(Bonus>6){
        return this.Name + " Lançou magia Super com bônus de " + Bonus;
      }else
      {
        return this.Name + " Lançou magia fraca com bônus " + Bonus;
      }
    }
  }
}