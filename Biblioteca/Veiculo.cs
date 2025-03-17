namespace Biblioteca
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        
        protected int AnoFabricacao;
        
        internal string Tipo;
        
        private string NumeroChassi;
        
        protected internal bool TemMotor;

        private protected bool EhMotorizado;
        public abstract void MostrarDetalhes();
    }
}

