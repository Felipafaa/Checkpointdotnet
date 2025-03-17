using Biblioteca;
using System;
class Program
{

    static void Main()
    {
        Carro umCarro = new Carro("Toyota Corolla", 2020)
        {
            QuantidadePortas = 4
        };

        umCarro.DefinirArCondicionado(true);

   
        Moto umaMoto = new Moto("Honda CG 160", 2022)
        {
            TemPartidaEletrica = true,
            TemBaul = false
        };

    
        InfodeVeiculo servico = new InfodeVeiculo();

        Console.WriteLine("Informações dos Veículos:");
        servico.MostrarInformacoes(umCarro);
        servico.MostrarInformacoes(umaMoto);
    }
}