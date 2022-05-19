// See https://aka.ms/new-console-template for more information

using rpg.src.Entities;

Knight arus = new Knight("Arus", 23, "Knight", 749, 72);
Wizard jenica = new Wizard("Jenica", 23, "White Wizard", 601, 482);
Ninja wedge = new Ninja("Wedge", 23, "Ninja", 574, 89);
BlackWizard topapa = new BlackWizard("Topapa", 23, "Black Wizard", 385, 641);

Console.WriteLine(arus.Attack());
Console.WriteLine(jenica.Attack(8));
Console.WriteLine(wedge.Attack());
Console.WriteLine(topapa.Attack(2));