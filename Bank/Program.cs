using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaconta = new Conta(TipoConta.PessoaFisica, 0, 0, "Diogo");
            Console.WriteLine(minhaconta.ToString());
        }
    }
}
