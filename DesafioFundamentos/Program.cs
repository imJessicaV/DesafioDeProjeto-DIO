using DesafioFundamentos;
using DesafioFundamentos.Models;
using Newtonsoft.Json;

Vendas V1 = new  Vendas(1, "Caderno Star Wars", 25.00M);

string serializado = JsonConvert.SerializeObject(V1, Formatting.Indented); //serialização do objeto

File.WriteAllText("Arquivos/vendas.json", serializado); //transforma o objeto serializado em um arqquivo com o conteudo do objeto serializado

Console.WriteLine(serializado);

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
