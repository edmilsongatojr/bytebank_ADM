namespace bytebank_ADM.Funcionarios
{
    public class Funcionario {

        public string nome;
        public string cpf;
        public double salario;

        public string Nome { get; set; }
        public string Cpf { get; set;}
        public double Salario { get; set; }


        public double getBonificacao() {
            return Salario * 0.1;
        }

    }
}
