using System;


namespace Biblioteca
{
    public class Moto : Veiculo
    {
  



        public bool TemPartidaEletrica { get; set; }
        public bool TemBaul;
        public Moto(string modelo, int ano)
        {
            Modelo = modelo;
            AnoFabricacao = ano;
            Tipo = "Moto";
            TemMotor = true;
            EhMotorizado = true;
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"Moto: {Modelo}," +
                $" Ano: {AnoFabricacao}, Partida Elétrica: {TemPartidaEletrica}");
        }
    }
}

