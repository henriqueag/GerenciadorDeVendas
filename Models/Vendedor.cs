namespace GerenciadorDeVendas.Models
{
    public class Vendedor : Pessoa
    {
        public decimal Comissao { get; set; }
        public int QtdVendas { get; set; }
    }
}
