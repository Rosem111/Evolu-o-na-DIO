/* 
Os 4 pilares da ORIENTAÇÃO A OBJETOS saõ o H.E.P.A :
 Herança - Você herda os comportamentos de uma outra classe.
 Encapsulamento - Você concentra as regra do negócio dentro da própria classe.
 Polimorfismo - Você tem um método com o mesmo nome mais com diferentes comportamentos.
 Abstração - Você faz uma representação em geral de alguma coisa em comum para que 
             se comece a herdar.
 
 */

using Demo1.src.entities; // Em cima do nome da classe - Control (.) para usar esse using.
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
