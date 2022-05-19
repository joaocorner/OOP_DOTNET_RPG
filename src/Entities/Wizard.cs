namespace rpg.src.Entities
{
  public class Wizard : Hero
  {
    public Wizard(string Name, int Level, string HeroType, int HP, int MP) : base(Name, Level, HeroType, HP, MP)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
      this.HP = HP;
      this.MP = MP;
    }
    public override string Attack()
    {
      return this.Name + " atacou com magia. ";
    }

    public string Attack(int Bonus)
    {

      if (Bonus > 6)
      {
        return this.Name + " Lançou magia super efetiva com bônus de " + Bonus;
      }
      else
      {
        return this.Name + " Lançou magia com força fraca com bônus de " + Bonus;
      }


    }

  }
}