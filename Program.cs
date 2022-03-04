using static System.Console;
using dotnet_poo.src.Entities;

class Program
{
    static void Main(string[] args)
    {
        Knigth arus = new Knigth("Arus", 42, 469, 749, 72, 72, "Knight");
        Ninja wedge = new Ninja("Wedge", 42, 292, 574, 89, 89, "Ninja");
        Wizard wizard = new Wizard("Jennica", 42, 325, 601, 474, 482, "White Wizard");
        BlackWizard blackWizard = new BlackWizard("Topapa", 42, 106, 385, 611, 641, "Black Wizard");


        WriteLine(arus.ToString());
        WriteLine("");
        WriteLine(wedge.ToString());
        WriteLine("");
        WriteLine(wizard.ToString());
        WriteLine("");
        WriteLine(blackWizard.ToString());
        WriteLine("");
        WriteLine(arus.Attack(5));
        WriteLine(wedge.Defense(9));
        WriteLine(wedge.Attack(7));
        WriteLine(arus.Defense(5));
        WriteLine(wizard.Attack());
        WriteLine(blackWizard.Defense());
        WriteLine(blackWizard.Attack());
        WriteLine(wizard.Defense());






    }
}