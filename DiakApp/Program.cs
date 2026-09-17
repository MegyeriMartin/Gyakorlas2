using DiakApp;
Diak parameternelkul = new Diak();
Diak egyparameteres = new Diak("Nagy Árpi");
Diak ketparameteres = new Diak("Kis árpi", 3.6);

Console.WriteLine($"Parameter nelkuli konstruktor: {parameternelkul.Nev}, Atlag:{parameternelkul.Atlag}");
Console.WriteLine($"Egyparameteres konstruktor: {egyparameteres.Nev}, Atlag:{egyparameteres.Atlag}");
Console.WriteLine($"Ketparameteres konstruktor: {ketparameteres.Nev}, Atlag:{ketparameteres.Atlag}");