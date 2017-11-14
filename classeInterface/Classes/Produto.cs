namespace ClasseInterface.Classes
{
    public class Produto : IAcao
    {
        public int Id  { get; set; }
        public string Nome { get; set; }   
        public string Descricao { get; set; }   
        public double Preco { get; set; }  

        public Produto(){}
        public Produto(int id, string nome, string descricao, double preco){
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
        }

        public string Cadastrar(){
            string composição = "Id do Produto: "+Id+
                                "\nNome do Produto: "+Nome.ToUpper()+
                                "\nDescrição do Produto: "+Descricao+
                                "\nPreço do Produto: "+string.Format("{c}",Preco);

            return "Produto cadastrado\n"+composição;
        }
        public string Consultar(){
           
           throw new System.NotImplementedException();
        }
    }
}