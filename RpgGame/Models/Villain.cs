namespace RpgGame.Models
{
  public class Villain : Hero
  {
    public bool Life { get; set; }

    public Villain()
    {
      Name = string.Empty;
      TypeHero = string.Empty;
    }
    public Villain(string Name, int Level, string TypeHero)
    {
      this.Name = Name;
      this.Level = Level;
      this.TypeHero = TypeHero;
      this.Life = true;
    }

    public override string ToString()
    {
      return this.Name + " " + this.Level + " " + this.TypeHero;
    }
  }
}