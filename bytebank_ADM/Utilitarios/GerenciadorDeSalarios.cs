using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.Utilitarios
{
    public class GerenciadorDeSalarios
    {

        private double totalDeSalarios;

        public double getTotalSalario()
        {
            return totalDeSalarios; ;
        }

        public  void RegistrarSalario(Funcionario funcionario)
        {
            this.totalDeSalarios +=  funcionario.getSalario();
        }
        public void RegistrarSalario(Diretor diretor)
        {
            this.totalDeSalarios += diretor.getSalario();
        }
    }
}
