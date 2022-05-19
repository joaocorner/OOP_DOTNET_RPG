// See https://aka.ms/new-console-template for more information

using rpg.src.Entities;

Knight arus = new Knight("Arus", 23, "Knight");
Wizard wizard = new Wizard("Jenica", 23, "White Wizard");

Console.WriteLine(arus.Attack());
Console.WriteLine(wizard.Attack());
Console.WriteLine(wizard.Attack(8));
Console.WriteLine(wizard.Attack(2));