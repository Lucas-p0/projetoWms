﻿using System.Text.Json;
using projetoWms.Classes;
using projetoWms.Filtros;

static void mensagemBoasVindas()
{
    Console.Clear();
    string mesagem = @"
██████╗ ██████╗  ██████╗      ██╗███████╗████████╗ ██████╗       ██╗    ██╗███╗   ███╗███████╗
██╔══██╗██╔══██╗██╔═══██╗     ██║██╔════╝╚══██╔══╝██╔═══██╗      ██║    ██║████╗ ████║██╔════╝
██████╔╝██████╔╝██║   ██║     ██║█████╗     ██║   ██║   ██║█████╗██║ █╗ ██║██╔████╔██║███████╗
██╔═══╝ ██╔══██╗██║   ██║██   ██║██╔══╝     ██║   ██║   ██║╚════╝██║███╗██║██║╚██╔╝██║╚════██║
██║     ██║  ██║╚██████╔╝╚█████╔╝███████╗   ██║   ╚██████╔╝      ╚███╔███╔╝██║ ╚═╝ ██║███████║
╚═╝     ╚═╝  ╚═╝ ╚═════╝  ╚════╝ ╚══════╝   ╚═╝    ╚═════╝        ╚══╝╚══╝ ╚═╝     ╚═╝╚══════╝                                                                                              
";
    Console.WriteLine(mesagem);
}

mensagemBoasVindas();

using (HttpClient client = new())
{
    string URL_API = "https://raw.githubusercontent.com/Lucas-p0/projetoWms/main/EstoqueAutoPecas.json";

    try
    {
        string response = await client.GetStringAsync(URL_API);
        var consulta = JsonSerializer.Deserialize<List<Estoque>>(response);
        FiltrosEstoque.FiltraTodosOsitensDoEstoque(consulta);


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Deu erro aquiii: {ex.Message}");
    }
}