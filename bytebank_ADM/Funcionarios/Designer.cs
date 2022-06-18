namespace bytebank_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf,double salario):base(cpf,salario)
        {
          
        }
        public override double getBonificacao()
        {

            return Salario + base.getBonificacao();

        }

        public override double getSalario()
        {
            return Salario;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
