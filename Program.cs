using ClassificadorHeroi;

Console.WriteLine("--- Classificador de Heróis ---");
Console.Write("Digite o nome do herói: ");
string nome = Console.ReadLine() ?? "Herói Desconhecido";

int xp;

while (true)
{
    Console.Write("Quanto de XP ele possui? ");
    string entrada = Console.ReadLine();

    if (int.TryParse(entrada, out xp)) 
    {
        break;
    }

    Console.WriteLine("Por favor, insira um valor numérico válido para o XP.");
}

Heroi heroi = new Heroi(nome, xp);
Console.WriteLine($"O herói {heroi.Nome} com {heroi.Xp} de XP é classificado como: {heroi.Classificacao}");