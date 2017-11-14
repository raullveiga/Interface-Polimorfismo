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
        }
    }
}
