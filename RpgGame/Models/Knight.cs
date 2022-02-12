namespace RpgGame.Models
{
  public class Knight : Hero
  {
    public Knight()
    {
      Name = string.Empty;
      TypeHero = string.Empty;
    }

    public Knight(string Name, int Level, string TypeHero)
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