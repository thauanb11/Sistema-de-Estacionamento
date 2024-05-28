using System;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Seja bem-vindo ao Estacionamento!");

        Console.WriteLine("Digite o preço inicial por hora de estacionamento:");
        decimal precoPorHora = decimal.Parse(Console.ReadLine());

        Estacionamento estacionamento = new Estacionamento(precoPorHora);
        bool exibirMenu = true;

       
        while (exibirMenu)
        {
            
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Adicionar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");

            string opcao = Console.ReadLine();

           
            switch (opcao)
            {
                case "1":
                Console.WriteLine("Digite a placa do veículo:");
                string placa = Console.ReadLine();
                estacionamento.AdicionarVeiculo(placa);
                    break;
                case "2":
                Console.WriteLine("Digite a placa do veículo:");
                placa = Console.ReadLine();
                estacionamento.RemoverVeiculo(placa);
                    break;
                case "3":
                    estacionamento.ListarVeiculos();
                    break;
                case "4":
                    exibirMenu = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine(); 
        }
    }
}
