var jogador1 = new Jogador("ChikoLoko");
jogador1.Deck.Add(new CartaDeMonstro("Dragão Baiano de olhos azuis", 3000, 2500));

foreach (var carta in jogador1.Deck)
{
    Console.WriteLine(carta.Nome);
    Console.WriteLine(carta.PoderDeAtaque);
}

class Partida
{
    public int Turno { get; set; }

}
class Jogador
{
    public string Nome { get; set; }
    public int Vida { get; set; }
    public List<CartaDeMonstro> Deck { get; set; } = new List<CartaDeMonstro>();
    public Jogador(string nome)
    {
        Nome = nome;
        Vida = 8000;
    }
}

class Carta
{
    public string Nome { get; set; }
    
    public Carta(string nome)
    {
        Nome = nome;
    }
}

class CartaDeMonstro : Carta
{
    public int PoderDeAtaque { get; set; }
    public int PoderDeDefesa { get; set; }

    public CartaDeMonstro(string nome, int poderDeAtaque, int poderDeDefesa) : base(nome) 
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

}