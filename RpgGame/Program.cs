using static System.Console;
using RpgGame.Models;

WriteLine("\tFinal Fantasy\n");

Warrior arus = new Warrior("Arus", 12, "Knight");
Wizzard jenica = new Wizzard("Jennica", 10, "White Wizzard");
Villain maleficus = new Villain("Maleficus", 50, "Devil");

WriteLine($"Personagem: {arus}");
WriteLine(arus.Attack());
WriteLine(arus.Attack("espadas"));

WriteLine();
WriteLine($"Personagem: {jenica}");
WriteLine(jenica);
WriteLine(jenica.Attack());
WriteLine(jenica.Attack("fogo"));

WriteLine();
WriteLine($"Personagem: {maleficus}");
