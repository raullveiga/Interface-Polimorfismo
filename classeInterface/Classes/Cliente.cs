namespace ClasseInterface.Classes
{
    public abstract class Cliente 
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public End Endereco { get; set; }

        public Cliente()
        {

        }
        public Cliente(int id, string email, string telefone, End endereco)
        {
            Id = id;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }

        
    }
}