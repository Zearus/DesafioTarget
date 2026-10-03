using System.Text.Json;

class Program
{
    static void Main()
    {
        string caminhoArquivo = "vendas.json";

        if (!File.Exists(caminhoArquivo))
        {
            Console.WriteLine("Arquivo vendas.json não encontrado.");
            return;
        }

        string json = File.ReadAllText(caminhoArquivo);

        DadosVendas dados = JsonSerializer.Deserialize<DadosVendas>(json);

        Dictionary<string, decimal> comissoes = new();

        foreach (Venda venda in dados.vendas)
        {
            decimal percentualComissao;

            if (venda.valor < 100)
            {
                percentualComissao = 0;
            }
            else if (venda.valor < 500)
            {
                percentualComissao = 0.01m;
            }
            else
            {
                percentualComissao = 0.05m;
            }

            decimal comissao = venda.valor * percentualComissao;

            if (!comissoes.ContainsKey(venda.vendedor))
            {
                comissoes[venda.vendedor] = 0;
            }

            comissoes[venda.vendedor] += comissao;
        }

        Console.WriteLine("===== COMISSÕES =====\n");

        foreach (var comissao in comissoes)
        {
            Console.WriteLine(
                $"{comissao.Key}: R$ {comissao.Value:F2}"
            );
        }
    }
}