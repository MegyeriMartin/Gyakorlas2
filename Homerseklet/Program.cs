using Homerseklet;

HomersekletAtvalto peldany = new HomersekletAtvalto();
peldany.Celsius = 25;
Console.WriteLine(peldany.ToFahrenheit());

double atadas = 30;
Console.WriteLine(HomersekletAtvalto.CelsiusToFahrenheit(atadas));
