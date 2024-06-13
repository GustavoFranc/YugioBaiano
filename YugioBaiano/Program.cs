var jogador1 = new Jogador("ChikoLoko");
jogador1.Deck.Add(new CartaDeMonstro(1, "Dragão Baiano de olhos azuis", 3000, 2500));

var jogador2 = new Jogador("DowngradeSon");
jogador2.Deck.Add(new CartaDeMonstro(2, "Dragão Baiano de olhos azuis", 3000, 2500));

var partida = new Partida
{
	Jogador1 = jogador1,
	Jogador2 = jogador2,
	JogadorAtual = jogador1,//atribuiir depois de joken po futuramente,
	Turno = 1
};

while (!partida.PartidaFinalizada)
{
	if (partida.Jogador1.Vida <= 0 || partida.Jogador2.Vida <= 0) partida.PartidaFinalizada = true;
	//ações do jogador
	Console.WriteLine("Escolha uma das opcoes(4 = ver deck player atual):");
	var escolha = Console.ReadLine();
	switch ((AcoesPlayer)Enum.Parse(typeof(AcoesPlayer), escolha))
	{
		case AcoesPlayer.VerDeck:
			foreach (var card in partida.JogadorAtual.Deck)
			{
				Console.WriteLine(card.ToString());

			}
			break;
	}
}

//passar classe para arquivos separados criando pastas

//

//criar função que cria partida esperando jogadores


//criar funcao que adiciona uma carta do deck para mao


//criar funcao que embaralha o deck(plus)

//criar funcao que troca de player baseado no player atual

//criar funcao que limpa tela

//criar funcao que exibe menu de opções

//separar em uma funcao o switch das acoes do jogador



enum AcoesPlayer
{
	Passar,
	VerMao,
	VerCemiterio,
	VerCampo,
	VerDeck,
	LimparTela
}



class Partida
{
	public int Turno { get; set; }
	public Jogador Jogador1 { get; set; } = null!;
	public Jogador Jogador2 { get; set; } = null!;
	public Jogador JogadorAtual { get; set; } = null!;
	public bool PartidaFinalizada { get; set; } = false;


}
class Jogador
{
	public string Nome { get; set; }
	public int Vida { get; set; }
	public List<Carta> Deck { get; set; } = new List<Carta>();
	public List<Carta> CartasCampo { get; set; } = new List<Carta>();
	public List<Carta> CartasCemiterio { get; set; } = new List<Carta>();

	public Jogador(string nome)
	{
		Nome = nome;
		Vida = 8000;
	}
}

abstract class Carta
{
	public string Nome { get; set; }
	public long Id { get; set; }

	public Carta(string nome, long id)
	{
		Nome = nome;
		Id = id;
	}

	public override abstract string ToString();
}

class CartaDeMonstro : Carta
{
	public int PoderDeAtaque { get; set; }
	public int PoderDeDefesa { get; set; }

	public bool Defesa { get; set; } = false;

	public CartaDeMonstro(long id, string nome, int poderDeAtaque, int poderDeDefesa) : base(nome, id)
	{
		Nome = nome;
		PoderDeAtaque = poderDeAtaque;
		PoderDeDefesa = poderDeDefesa;
	}

	public int Atacar()
	{
		return PoderDeAtaque;
	}

	public int Defender()
	{
		return PoderDeDefesa;
	}

	public override string ToString()
	{
		return $"\n Carta:{Nome} \n Ataque:{PoderDeAtaque} \n Defesa:{PoderDeDefesa}";
	}

}