using projetoWms.Classes;
using System.Linq;


namespace projetoWms.Filtros;

public class FiltrosEstoque
{
    public static void FiltraTodosOsitensDoEstoque(List<Estoque> consultas)
    {
        var filtraTodosOsItens = consultas.Select(c => c.NomeProduto).ToList();
        filtraTodosOsItens.Sort();
        //int quantidadeEstoque = filtraTodosOsItens.Count();
        //System.Console.WriteLine(quantidadeEstoque);
        foreach (var resultado in filtraTodosOsItens)
        {
            System.Console.WriteLine($"{resultado}");
        }
    }
}
