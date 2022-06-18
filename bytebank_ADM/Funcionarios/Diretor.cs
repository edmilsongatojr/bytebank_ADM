namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf):base(cpf,5000)
        {
          
        }
        public override double getBonificacao()
        {

            return Salario * 0.5;

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
