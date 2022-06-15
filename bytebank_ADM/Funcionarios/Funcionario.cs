namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {

        // 0 – funcionário
        // 1 – diretor
        // 2 – designer
        // N - ... 

        //private int _tipo;

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }


        //public Funcionario(int _tipo)
        //{
        //    this._tipo = _tipo;
        //}

        public double getBonificacao()
        {
            return Salario * 0.1;
        }

        public double getSalario()
        {
            return Salario = 2000;
        }
    }

}
