using static System.Console;
using RpgGame.Models;

Hero arus = new Hero("Arus", 12, "Knight");
Villain maleficus = new Villain("Maleficus", 50, "Devil");

WriteLine(arus);
WriteLine(arus.Attack());

WriteLine(maleficus);