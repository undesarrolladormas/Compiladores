using Ejercicio_01.Automata;

Console.WriteLine("Escriba la cadena de texto:");
string? cadena = Console.ReadLine();

if(cadena == null) return;

List<string> values = new Automata_01().Match(cadena);


Console.WriteLine("\nCoincidencias:");
foreach (string value in values)
{
    Console.WriteLine(value);
}