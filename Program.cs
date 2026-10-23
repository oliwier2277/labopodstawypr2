// zad2 
int doswiadczenie = 33;
int zloto = 55;
int numerTreningu = 1;

Console.WriteLine("--- STAN POCZĄTKOWY ---");
Console.WriteLine($"Doswiadczenie: {doswiadczenie}");
Console.WriteLine($"Zloto: {zloto}");
Console.WriteLine($"Numer treningu: {numerTreningu}");

doswiadczenie += 55;
doswiadczenie *= 2;
zloto -= 10;
zloto += 17;
numerTreningu++;

Console.WriteLine("\n--- STAN KOŃCOWY ---");
Console.WriteLine($"Doswiadczenie: {doswiadczenie}");
Console.WriteLine($"Zloto: {zloto}");
Console.WriteLine($"Numer treningu: {numerTreningu}");
