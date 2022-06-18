namespace bytebank_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf):base(cpf,3000)
        {
          
        }
        public override double getBonificacao()
        {

            return Salario * 0.17;

        }

        public override double getSalario()
        {
            return Salario;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
