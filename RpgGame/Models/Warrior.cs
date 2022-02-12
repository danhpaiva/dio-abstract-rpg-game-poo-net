namespace RpgGame.Models
{
  public class Warrior : Hero
  {
    public Warrior()
    {
      Name = string.Empty;
      TypeHero = string.Empty;
    }

    public Warrior(string Name, int Level, string TypeHero)
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
      return this.Name + $" atacou com três {bonus}!";
    }
  }
}