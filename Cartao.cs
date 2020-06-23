namespace Aula23ListadeObjetos
{
    public class Cartao
    {
        public string Titular { get; set; }
        public string Numero { get; set; }
        public string Bandeira { get; set; }
        public int CVV { get; set; }
        public string Vencimento { get; set; }

        public Cartao(){
        }

        public Cartao(string _titular, string _numero, string _bandeira, string _vencimento, int _cvv)
        {
            this.Titular = _titular;
            this.Numero = _numero;
            this.Bandeira = _bandeira;
            this.CVV = _cvv;
            this.Vencimento = _vencimento;
        }
    }
}