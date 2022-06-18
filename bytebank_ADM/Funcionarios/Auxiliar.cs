namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf):base(cpf,2000)
        {
          
        }
        public override double getBonificacao()
        {

            return Salario * 0.20;

        }

        public override double getSalario()
        {
            return Salario;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.10;
        }
    }
}
