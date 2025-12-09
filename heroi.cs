namespace ClassificadorHeroi;

public class Heroi
{
    public string? Nome { get; set; }
    public int Xp { get; set;  }

    public Heroi(string nome, int xp)
    {
        Nome = nome;
        Xp = xp;
    }

    public string? Classificacao => Xp switch
        {
            <= 1000 => "Ferro",
            <= 2000 => "Bronze",
            <= 5000 => "Prata",
            <= 7000 => "Ouro",
            <= 8000 => "Platina",
            <= 9000 => "Ascendente",
            <= 10000 => "Imortal",
            _ => "Radiante"
        };
}