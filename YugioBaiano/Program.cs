class Jogador
{
    public string Nome { get; set; }
    public int Vida { get; set; }
    
    public Jogador(string nome, int vida)
    {
        Nome = nome;
        Vida = vida;
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