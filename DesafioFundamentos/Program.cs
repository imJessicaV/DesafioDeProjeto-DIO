using DesafioFundamentos;
using DesafioFundamentos.Models;
using Newtonsoft.Json;

string conteudoDoc = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda= JsonConvert.DeserializeObject<List<Venda>>(conteudoDoc);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id} | Produto: {venda.Produto} | Data da Venda: {venda.DataVenda.ToString("dd/MM/yyy HH:mm")})");

}


// DateTime dataAtual = DateTime.Now;

// List<Vendas> listaVendas = new List<Vendas>();

// Vendas V1 = new  Vendas(1, "Caderno Star Wars", 25.00M, dataAtual);
// Vendas V2 = new  Vendas(2, "Mochila Star Wars", 189.00M, dataAtual);
// Vendas V3 = new  Vendas(3, "Fichário Star Wars", 109.00M, dataAtual);

// listaVendas.Add(V1);
// listaVendas.Add(V2);
// listaVendas.Add(V3);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented); //serialização do objeto

// File.WriteAllText("Arquivos/vendas.json", serializado); //transforma o objeto serializado em um arqquivo com o conteudo do objeto serializado

// Console.WriteLine(serializado);

// // Coloca o encoding para UTF8 para exibir acentuação
// Console.OutputEncoding = System.Text.Encoding.UTF8;

// decimal precoInicial = 0;
// decimal precoPorHora = 0;
// DateTime registraHoraEntrada = DateTime.Now;
// DateTime registraHoraSaida = DateTime.Now;

// Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
//                   "Digite o preço inicial:");
// precoInicial = Convert.ToDecimal(Console.ReadLine());

// Console.WriteLine("Agora digite o preço por hora:");
// precoPorHora = Convert.ToDecimal(Console.ReadLine());

// // Instancia a classe Estacionamento, já com os valores obtidos anteriormente
// Estacionamento es = new Estacionamento(precoInicial, precoPorHora, registraHoraEntrada, registraHoraSaida);

// string opcao = string.Empty;
// bool exibirMenu = true;

// // Realiza o loop do menu
// while (exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar veículo");
//     Console.WriteLine("2 - Remover veículo");
//     Console.WriteLine("3 - Listar veículos");
//     Console.WriteLine("4 - Encerrar");

//     switch (Console.ReadLine())
//     {
//         case "1":
//             es.AdicionarVeiculo();
//             break;

//         case "2":
//             es.RemoverVeiculo();
//             break;

//         case "3":
//             es.ListarVeiculos();
//             break;

//         case "4":
//             exibirMenu = false;
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }

//     Console.WriteLine("Pressione uma tecla para continuar");
//     Console.ReadLine();
// }

// Console.WriteLine("O programa se encerrou");
