// See https://aka.ms/new-console-template for more information

using rpg.src.Entities;

Hero arus = new Hero("Arus", 23, "Knight");
Wizard wizard = new Wizard("Jenica", 23, "White Wizard");

Console.Write(arus.Attack());
Console.Write(wizard.Attack());