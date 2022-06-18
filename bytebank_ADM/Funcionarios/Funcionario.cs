namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {

        // 0 – funcionário
        // 1 – diretor
        // 2 – designer
        // N - ... 

        //private int _tipo;

        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }


        //public Funcionario(int _tipo)
        //{
        //    this._tipo = _tipo;
        //}

        public virtual double getBonificacao()
        {
            return Salario * 0.1;
        }

        public virtual double getSalario()
        {
            return Salario = 2000;
        }

        public static int totalDeFuncionarios { get; private set; }
        public Funcionario(string cpf,double salario)
        {
            Cpf = cpf;
            Salario = salario;  
            totalDeFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }

}
