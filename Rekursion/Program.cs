///////////////////////////////////////
using System.Diagnostics;
/// Berechnung der Fakultät von 10
/// 10! = 1*2*3*4*5*6*7*8*9*10
int i = 10;

Console.WriteLine($"Fakultät von {i} = {Fakultaet(i)}");
Console.WriteLine($"Fakultät (iterativ) von {i} = {FakultaetIterativ(i)}");

Console.WriteLine($"Summenformel von {i} = {Summenformel(i)}");

Console.WriteLine("\n----- Weihnachtsbaum -----");
int treeHeight = 7;
DrawChristmasTree(1, treeHeight);

/// Ermittlung der Fakultät (REKURSIV)
double Fakultaet(int i)
{
    if (i < 0)
        return 0;
    if (i == 1 || i == 0)
        return 1;
    
    return i * Fakultaet(i - 1);
}

/// Ermittlung der Fakultät (ITERATIV)
double FakultaetIterativ(int i)
{
    if (i <= 0)
        return 0;

    double fakultaet = 1;
    for (int j = 1; j < i; j++)
    {
        fakultaet = fakultaet * j;
    }
    return fakultaet;
}

/// Ermittlung der Summe aus den Ganzzahlen zwischen der oberen und unteren Schranke (REKURSIV)
int Summenformel(int obereSchranke, int untereSchranke = 0)
{
    if (obereSchranke <= untereSchranke)
        return obereSchranke;

    return obereSchranke + Summenformel(obereSchranke-1, untereSchranke);

}

static void DrawChristmasTree(int current, int total)
{
    if (current > total)
        return;

    string spaces = "";
    for (int i = 0; i < total - current; i++)
        spaces += " ";

    string stars = new string('*', 2 * current - 1);
    
    Console.WriteLine(spaces + stars);

    DrawChristmasTree(current + 1, total);
}