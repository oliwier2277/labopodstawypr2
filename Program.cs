// zad4 

Console.Write("Podaj punkty zycia: ");
int zycie = int.Parse(Console.ReadLine()!);

Console.Write("Podaj liczbe mikstur: ");
int mikstury = int.Parse(Console.ReadLine()!);

Console.Write("Czy masz klucz? (true/false): ");
bool klucz = bool.Parse(Console.ReadLine()!);

Console.Write("Czy masz mape? (true/false): ");
bool mapa = bool.Parse(Console.ReadLine()!);

bool zyje = zycie > 0;
bool maPelneZdrowie = zycie == 100;
bool wymagaLeczenia = !maPelneZdrowie;
bool maZaopatrzenie = mikstury >= 1;
bool maPrzedmiotNawigacyjny = klucz || mapa;
bool gotowyDoWyprawy = zyje && maZaopatrzenie && maPrzedmiotNawigacyjny;

Console.WriteLine();
Console.WriteLine("Wyniki:");

Console.WriteLine("Zyje: " + zyje);
Console.WriteLine("Ma pelne zdrowie: " + maPelneZdrowie);
Console.WriteLine("Wymaga leczenia: " + wymagaLeczenia);
Console.WriteLine("Ma zaopatrzenie: " + maZaopatrzenie);
Console.WriteLine("Ma klucz lub mape: " + maPrzedmiotNawigacyjny);
Console.WriteLine("Gotowy do wyprawy: " + gotowyDoWyprawy);

