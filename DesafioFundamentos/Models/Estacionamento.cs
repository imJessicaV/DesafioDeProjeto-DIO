namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private DateTime registraHoraEntrada;
        private DateTime registraHoraSaida;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora, DateTime registraHoraEntrada, DateTime registraHoraSaida)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.registraHoraEntrada = registraHoraEntrada;
            //this.registraHoraSaida = registraHoraSaida;

        }

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            string veiculo = Console.ReadLine();
            veiculos.Add(veiculo);
            registraHoraEntrada = DateTime.Now;

            Console.WriteLine($"Hora de entrada:{registraHoraEntrada} ");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                
                int horas = 0;
                int valorTotal = 0;
                DateTime registraHoraSaida = DateTime.Now;
                DateTime horaEstacionada = registraHoraEntrada.AddHours(horas);
            
                horas = Convert.ToInt32(Console.ReadLine()); ;//converte string para int
                valorTotal = Convert.ToInt32(precoInicial + precoPorHora * horas);

                veiculos.Remove(placa);

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
               // Console.WriteLine($"Hora de saida: {horaEstacionada}");  Estuda essa linha para somar a hora atual com as horas digitadas              
                Console.WriteLine($"O veiculo permaneceu {horas}h");
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"{veiculo} - Entrada: {registraHoraEntrada}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
