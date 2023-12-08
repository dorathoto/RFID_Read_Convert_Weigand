Console.Write("Digite o valor decimal da Intelbras: ");
int valorIntelbras = int.Parse(Console.ReadLine());

var valorWeigand = ConverteParaWeigand(valorIntelbras);

Console.WriteLine($"O valor Weigand correspondente é: {valorWeigand}");


//3265746  -> 4954482
static string ConverteParaWeigand(int valorIntelbras)
{
    string hex = valorIntelbras.ToString("X");

    string primeiraParteHex = hex[..2];
    string segundaParteHex = hex[2..];

    int valorWeigand = Convert.ToInt32(primeiraParteHex, 16);
    int valorWeigand2 = Convert.ToInt32(segundaParteHex, 16);

    return $"{valorWeigand}{valorWeigand2}";
}