public class Venda
{
    public string vendedor { get; set; }
    public decimal valor { get; set; }
}

public class DadosVendas
{
    public List<Venda> vendas { get; set; }
}