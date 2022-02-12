namespace RpgGame.Models
{
  public class Hero
  {
    public string Name { get; set; }
    public int Level { get; set; }
    public string TypeHero { get; set; }
    public Hero(string Name, int Level, string TypeHero)
    {
      this.Name = Name;
      this.Level = Level;
      this.TypeHero = TypeHero;
    }
  }
}