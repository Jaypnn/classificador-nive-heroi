ClassificarHeroi Classificarheroi = new ClassificarHeroi();
Console.WriteLine("Classificador de Herói");
Console.WriteLine("Digite o nome do herói:");
Classificarheroi.Nome = Console.ReadLine();
Console.WriteLine("Digite a quantidade de XP do herói:");
Classificarheroi.Xp = int.TryParse(Console.ReadLine(), out int xp) ? xp : 0;
Classificarheroi.Classificar();


public class ClassificarHeroi
{
    public string? Nome { get; set; }
    public int Xp { get; set;  }
    public string? Classificacao { get; set; }

    public void Classificar() {
        Classificacao = Xp switch
        {
            <= 1000 => "Ferro",
            <= 2000 => "Bronze",
            <= 5000 => "Prata",
            <= 7000 => "Ouro",
            <= 8000 => "Platina",
            <= 9000 => "Ascendente",
            <= 10000 => "Imortal",
             => "Radiante"
        };
        
        Console.WriteLine($"O herói de nome {Nome} está no nível de {Classificacao}.");
    }
}

    