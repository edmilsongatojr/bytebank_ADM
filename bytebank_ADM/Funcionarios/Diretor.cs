namespace bytebank_ADM.Funcionarios
{
    public class Diretor
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }


        public double getBonificacao()
        {
           
                return Salario;
           
            
        }

        public double getSalario()
        {
            return Salario = 7000;
        }
    }
}
