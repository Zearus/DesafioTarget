using System.Text.Json;

class Program
{
    static void Main()
    {
        string caminhoArquivo = "estoque.json";

        if (!File.Exists(caminhoArquivo))
        {
            Console.WriteLine("Arquivo estoque.json não encontrado.");
            return;
        }

        string json = File.ReadAllText(caminhoArquivo);

        DadosEstoque dados =
            JsonSerializer.Deserialize<DadosEstoque>(json);

        List<Movimentacao> movimentacoes = new();

        int proximoId = 1;

        while (true)
        {
            Console.WriteLine("\n===== CONTROLE DE ESTOQUE =====");
            Console.WriteLine("1 - Entrada");
            Console.WriteLine("2 - Saída");
            Console.WriteLine("3 - Consultar estoque");
            Console.WriteLine("4 - Consultar movimentações");
            Console.WriteLine("0 - Sair");

            Console.Write("\nOpção: ");
            string opcao = Console.ReadLine();

            if (opcao == "0")
                break;

            if (opcao == "3")
            {
                Console.WriteLine("\n===== ESTOQUE ATUAL =====");

                foreach (Produto produto in dados.estoque)
                {
                    Console.WriteLine(
                        $"Código: {produto.codigoProduto} | " +
                        $"Produto: {produto.descricaoProduto} | " +
                        $"Quantidade: {produto.estoque}"
                    );
                }

                continue;
            }

            if (opcao == "4")
            {
                Console.WriteLine("\n===== MOVIMENTAÇÕES =====");

                foreach (Movimentacao movimentacao in movimentacoes)
                {
                    Console.WriteLine(
                        $"ID: {movimentacao.Id} | " +
                        $"Produto: {movimentacao.CodigoProduto} | " +
                        $"Tipo: {movimentacao.Tipo} | " +
                        $"Quantidade: {movimentacao.Quantidade} | " +
                        $"Descrição: {movimentacao.Descricao}"
                    );
                }

                continue;
            }

            if (opcao != "1" && opcao != "2")
            {
                Console.WriteLine("Opção inválida.");
                continue;
            }

            Console.Write("Código do produto: ");

            if (!int.TryParse(
                Console.ReadLine(),
                out int codigoProduto))
            {
                Console.WriteLine("Código inválido.");
                continue;
            }

            Produto produto = dados.estoque.Find(
                p => p.codigoProduto == codigoProduto
            );

            if (produto == null)
            {
                Console.WriteLine("Produto não encontrado.");
                continue;
            }

            Console.Write("Quantidade: ");

            if (!int.TryParse(
                Console.ReadLine(),
                out int quantidade) ||
                quantidade <= 0)
            {
                Console.WriteLine("Quantidade inválida.");
                continue;
            }

            Console.Write("Descrição da movimentação: ");
            string descricao = Console.ReadLine();

            string tipo;

            if (opcao == "1")
            {
                tipo = "Entrada";

                produto.estoque += quantidade;
            }
            else
            {
                tipo = "Saída";

                if (quantidade > produto.estoque)
                {
                    Console.WriteLine(
                        $"Estoque insuficiente. " +
                        $"Disponível: {produto.estoque}"
                    );

                    continue;
                }

                produto.estoque -= quantidade;
            }

            Movimentacao movimentacao = new()
            {
                Id = proximoId,
                CodigoProduto = codigoProduto,
                Tipo = tipo,
                Descricao = descricao,
                Quantidade = quantidade
            };

            movimentacoes.Add(movimentacao);

            Console.WriteLine("\nMovimentação realizada!");
            Console.WriteLine($"ID: {movimentacao.Id}");
            Console.WriteLine($"Produto: {produto.descricaoProduto}");
            Console.WriteLine($"Tipo: {tipo}");
            Console.WriteLine($"Quantidade: {quantidade}");
            Console.WriteLine(
                $"Estoque final: {produto.estoque}"
            );

            proximoId++;
        }
    }
}