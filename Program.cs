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
        if (Xp <= 1000) {
            Classificacao = "Ferro";
        }

        else if (Xp >= 1001 && Xp <= 2000) {
            Classificacao = "Bronze";
        }

       else if (Xp >= 2001 && Xp <= 5000) {
            Classificacao = "Prata";
        }

        else if (Xp >= 5001 && Xp <= 7000) {
            Classificacao = "Ouro";
        }

        else if (Xp >= 7001 && Xp <= 8000) {
            Classificacao = "Platina";
        }

        else if (Xp >= 8001 && Xp <= 9000) {
            Classificacao = "Ascendende";
        }

        else if (Xp >= 9001 && Xp <= 10000) {
            Classificacao = "Imortal";
        }
    
        else if (Xp >= 10001) {
            Classificacao = "Radiante";
        }
        
        Console.WriteLine($"O herói de nome {Nome} está no nível de {Classificacao}.");
    }
}

    