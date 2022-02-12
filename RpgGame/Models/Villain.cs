namespace RpgGame.Models
{
  public class Villain : Hero
  {
    public int HP { get; set; }
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
      this.HP = 100;
      this.Life = true;
    }

    public override string ToString()
    {
      return this.Name + " " + this.Level + " " + this.TypeHero;
    }
    public string VerificaDanos(Hero hero, Villain villain)
    {
      if (hero.Name == "Arus")
      {
        villain.HP -= 60;
      }
      else
      {
        villain.HP -= 30;
      }
      return this.Name + $" está com {this.HP} de HP.";
    }
  }
}