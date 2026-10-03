public class Produto
{
    public int codigoProduto { get; set; }
    public string descricaoProduto { get; set; }
    public int estoque { get; set; }
}

public class DadosEstoque
{
    public List<Produto> estoque { get; set; }
}