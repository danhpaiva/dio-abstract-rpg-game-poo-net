namespace RpgGame.Models
{
  public class Wizzard : Hero
  {
    public Wizzard()
    {
      Name = string.Empty;
      TypeHero = string.Empty;
    }

    public Wizzard(string Name, int Level, string TypeHero)
    {
      this.Name = Name;
      this.Level = Level;
      this.TypeHero = TypeHero;
    }

    public override string ToString()
    {
      return this.Name + " " + this.Level + " " + this.TypeHero;
    }

    public override string Attack()
    {
      return this.Name + " lançou magia!";
    }

    public string Attack(string bonus)
    {
      return this.Name + $" lançou magia com {bonus}!";
    }
  }
}