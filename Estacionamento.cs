using System;
using System.Collections.Generic;

public class Estacionamento
{
    private List<string> veiculos = new List<string>();
    private Dictionary<string, DateTime> tempoEntrada = new Dictionary<string, DateTime>();
    private decimal precoPorHora;

    public Estacionamento(decimal precoPorHora)
    {
        this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo(string placa)
    {
        veiculos.Add(placa);
        tempoEntrada[placa] = DateTime.Now;
        Console.WriteLine($"Veículo de placa {placa} adicionado com sucesso.");
    }

    public void RemoverVeiculo(string placa)
    {
        if (veiculos.Remove(placa))
        {
            tempoEntrada.Remove(placa);
            Console.WriteLine($"Veículo de placa {placa} removido com sucesso.");
        }
        else
        {
            Console.WriteLine($"Veículo de placa {placa} não encontrado.");
        }
    }

    public void ListarVeiculos()
    {
        Console.WriteLine("Veículos estacionados:");
        foreach (var veiculo in veiculos)
        {
            Console.WriteLine(veiculo);
        }
    }
}
