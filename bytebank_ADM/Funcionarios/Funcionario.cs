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
        public static int totalDeFuncionarios { get; private set; }
        public Funcionario(string cpf, double salario)
        {
            Cpf = cpf;
            Salario = salario;
            totalDeFuncionarios++;
        }
        public abstract double getBonificacao();

        public abstract double getSalario();

        public abstract void AumentarSalario();
       
        
    }

}
