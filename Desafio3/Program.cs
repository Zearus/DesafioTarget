using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== CALCULADORA DE JUROS =====\n");

        Console.Write("Digite o valor: ");

        if (!decimal.TryParse(
            Console.ReadLine(),
            NumberStyles.Number,
            CultureInfo.GetCultureInfo("pt-BR"),
            out decimal valor) || valor < 0)
        {
            Console.WriteLine("Valor inválido.");
            return;
        }

        Console.Write("Digite a data de vencimento (dd/MM/yyyy): ");

        if (!DateTime.TryParseExact(
            Console.ReadLine(),
            "dd/MM/yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out DateTime dataVencimento))
        {
            Console.WriteLine("Data inválida.");
            return;
        }

        DateTime dataAtual = DateTime.Today;

        if (dataVencimento >= dataAtual)
        {
            Console.WriteLine("\nA dívida não está atrasada.");
            Console.WriteLine($"Valor a pagar: R$ {valor:F2}");
            return;
        }

        int diasAtraso = (dataAtual - dataVencimento).Days;

        decimal taxaDiaria = 0.025m;

        decimal juros = valor * taxaDiaria * diasAtraso;

        decimal valorFinal = valor + juros;

        Console.WriteLine("\n===== RESULTADO =====");
        Console.WriteLine($"Valor original: R$ {valor:F2}");
        Console.WriteLine(
            $"Vencimento: {dataVencimento:dd/MM/yyyy}"
        );
        Console.WriteLine(
            $"Data atual: {dataAtual:dd/MM/yyyy}"
        );
        Console.WriteLine($"Dias de atraso: {diasAtraso}");
        Console.WriteLine($"Taxa diária: 2,5%");
        Console.WriteLine($"Juros: R$ {juros:F2}");
        Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
    }
}