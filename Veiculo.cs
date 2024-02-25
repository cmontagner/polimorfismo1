namespace Polimorfismo
{
    public class Veiculo
    {
        private string _tipo;

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public Veiculo(string tipoVeiculo) 
        {
            _tipo = tipoVeiculo;
        }

        public virtual void Mover()
        { 
        }

        public virtual void Parar() 
        {
        }
    }
}
