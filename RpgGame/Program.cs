using static System.Console;
using RpgGame.Models;

Hero arus = new Hero("Arus", 12, "Knight");

WriteLine($"Hero: {arus.Name}\nLevel: {arus.Level}\nType: {arus.TypeHero}");