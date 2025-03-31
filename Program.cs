Console.Clear();

Console.WriteLine("--------- Forca ---------");
Console.WriteLine("Digite  a palavra secreta");
string palavra = Console.ReadLine()!.ToLower();

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine()!.ToLower();

bool existe = palavra.Contains(letra);
Console.WriteLine($"A letra \"{letra.ToUpper()}\" existe na palavra secreta => {existe}");