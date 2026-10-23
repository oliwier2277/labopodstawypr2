// zad3

Console.Write("Podaj liczbe racji: ");
int racje = int.Parse(Console.ReadLine()!);

Console.Write("Podaj liczbe czlonkow druzyny: ");
int czlonkowie = int.Parse(Console.ReadLine()!);

Console.Write("Podaj liczbe dni wyprawy: ");
int dni = int.Parse(Console.ReadLine()!);

int racjeNaOsobe = racje / czlonkowie;
int pozostaleRacje = racje % czlonkowie;

double racjeDziennie = (double)racje / dni;
double racjeDziennieNaOsobe = racjeDziennie / czlonkowie;

Console.WriteLine();
Console.WriteLine("Wyniki obliczen:");

Console.WriteLine("Racje na osobe: " + racjeNaOsobe);
Console.WriteLine("Pozostale racje: " + pozostaleRacje);
Console.WriteLine("Racje dziennie dla druzyny: " + racjeDziennie.ToString("F2"));
Console.WriteLine("Racje dziennie na osobe: " + racjeDziennieNaOsobe.ToString("F2"));
