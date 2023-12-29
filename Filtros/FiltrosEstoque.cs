using projetoWms.Classes;

namespace projetoWms.Filtros;

public class FiltrosEstoque
{
    public static void FiltraTodosOsitensDoEstoque(List<Estoque> consultas)
    {
        var filtraTodosOsItens = consultas.Select(c => c.NomeProduto).ToList();
        foreach (var resultado in filtraTodosOsItens)
        {
            System.Console.WriteLine(resultado);
        }
    }
}
