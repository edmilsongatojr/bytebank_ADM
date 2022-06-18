namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string cpf):base(cpf,4000)
        {
          
        }
        public override double getBonificacao()
        {

            return Salario * 0.25;

        }

        public override double getSalario()
        {
            return Salario;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }
}
