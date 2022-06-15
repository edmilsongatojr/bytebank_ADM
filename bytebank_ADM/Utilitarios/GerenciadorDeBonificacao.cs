using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.Utilitarios
{
    public class GerenciadorDeBonificacao
    {

        //public double totalBonificacao { get; set; }

        private double totalBonificacao;
        public double getBonificacao()
        {
            return this.totalBonificacao;
        }

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.getBonificacao();
        }

        public void Registrar(Diretor diretor)
        {
            this.totalBonificacao += diretor.getBonificacao();
        }
    }
}
