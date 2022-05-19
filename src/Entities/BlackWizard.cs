namespace rpg.src.Entities
{
  public class BlackWizard : Wizard
  {
    public BlackWizard(string Name, int Level, string HeroType, int HP, int MP) : base(Name, Level, HeroType, HP, MP)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
      this.HP = HP;
      this.MP = MP;
    }
  }
}