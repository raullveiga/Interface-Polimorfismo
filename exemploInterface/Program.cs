using System;
using  ClasseInterface.Classes;

namespace exemploInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto pr = new Produto(31,"Batata","popoó",3.50);
            System.Console.WriteLine(pr.Cadastrar());
            Console.WriteLine();
            
            End endereco = new End();
            endereco.Logradouro = "fdksh";
            endereco.Numero = "43";
            endereco.Bairro = "rfdso";

            PF pf = new PF(10,"Batata","rlsdkjsdrlkj",endereco,"reihu","124215");

            System.Console.WriteLine(pf.Cadastrar());
        }
    }
}
