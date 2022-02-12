namespace RpgGame.Models
{
  public class Hero
  {
    public string Name { get; set; }
    public int Level { get; set; }
    public string TypeHero { get; set; }
    public Hero()
    {
      Name = string.Empty;
      TypeHero = string.Empty;
    }
    public Hero(string Name, int Level, string TypeHero)
    {
      this.Name = Name;
      this.Level = Level;
      this.TypeHero = TypeHero;
    }

    public override string ToString()
    {
      return this.Name + " " + this.Level + " " + this.TypeHero;
    }

    public string Attack()
    {
      return this.Name + "Atacou com sua espada!";
    }
  }
}