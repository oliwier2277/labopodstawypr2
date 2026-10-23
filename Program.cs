// zad8

Console.Write("Podaj punkty zycia: ");
int zycie = int.Parse(Console.ReadLine()!);

Console.Write("Czy masz klucz? (true/false): ");
bool klucz = bool.Parse(Console.ReadLine()!);

Console.Write("Czy znasz haslo? (true/false): ");
bool haslo = bool.Parse(Console.ReadLine()!);

if (zycie <= 0)
{
    Console.WriteLine("Bohater nie moze wejsc - nie zyje.");
}
else if (zycie > 0 && (klucz || haslo))
{
    Console.WriteLine("Bohater moze wejsc do lochu.");
}
else
{
    Console.WriteLine("Bohater nie moze wejsc - nie ma sposobu otwarcia drzwi.");
}

