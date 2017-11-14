namespace ClasseInterface.Classes
{
    public class PF : Cliente, IAcao
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public PF()
        {
            
        }
        public PF(int id, string email, string telefone, End endereco, string nome, string cpf)
        {
            Id = id;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Nome = nome;
            CPF = cpf;
        }

        public string Cadastrar()
        {
            string rt =         "Id do Cliente: "+Id+
                                "\nNome do Cliente: "+Nome.ToUpper()+
                                "\nEmail: "+Email+
                                "\nEndereço: "+Endereco.Logradouro+" ,"+Endereco.Numero+" ,"+Endereco.Bairro+
                                "\nTelefone: "+Telefone+
                                "\nCPF: "+CPF;
            return rt;
        }

        public string Consultar()
        {
            throw new System.NotImplementedException();
        }
    }
}