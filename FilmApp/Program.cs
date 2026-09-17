using FilmApp;

film elsofilm = new film();
elsofilm.Cim = "A Gyuruk ura";
elsofilm.HosszPercben = 190;

film masodikfilm = new film();
Console.WriteLine("adja meg a masodik film cimet");
masodikfilm.Cim = Console.ReadLine();
Console.WriteLine("Adja meg a masodik film hosszat");
masodikfilm.HosszPercben = int.Parse(Console.ReadLine());

Console.WriteLine($"az elso film cime: {elsofilm.Cim}, az elso film hossza: {elsofilm.HosszPercben}.");
Console.WriteLine($"az elso film cime: {masodikfilm.Cim}, az elso film hossza: {masodikfilm.HosszPercben}.");