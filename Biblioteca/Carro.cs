using System;

namespace Biblioteca
{
    public class Carro : Veiculo
    {




        public int QuantidadePortas { get; set; }
        internal bool TemArCondicionado;

        public void DefinirArCondicionado(bool valor)
        {
            TemArCondicionado = valor;
        }


        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            AnoFabricacao = ano;
            Tipo = "Carro";
            TemMotor = true;
            EhMotorizado = true;
        }
     

      
        public override void MostrarDetalhes()
        {
            Console.WriteLine($"Carro: {Modelo}, " +
            $"Ano: {AnoFabricacao}, Portas: {QuantidadePortas}");
        }
    }
}

