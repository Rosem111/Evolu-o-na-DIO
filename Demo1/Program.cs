
using Demo1.src.entities; 
using Microsoft.VisualBasic;

Knight Arus = new Knight("Arus", 23, "Knight");
Ninja Weidge = new Ninja("Weidge", 23, "Ninja");
Wizard Jennica = new Wizard("Jennica", 23, "White Wizard");
Wizard2 Topapa = new Wizard2("Topapa", 23, "Black Wizard");

Console.WriteLine("DUNGEON DIO\n");

Console.WriteLine(Arus.Attack());
Console.WriteLine(Weidge.Attack());
Console.WriteLine(Jennica.Attack(7));
Console.WriteLine(Topapa.Attack());

Console.ReadKey();
