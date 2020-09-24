using System;

namespace ConjecturaDeCollatz
{
    class Program
    {
        static void Main(string[] args)
        {
            Collatz collatz = new Collatz();
            IServiceCollatz iServiceCollatz = new ServiceCollatz();
            ICollatz iCollatz = new RepositoryCollatz();
            iServiceCollatz.CalculoDeCollatz(1000000, collatz);
            Console.WriteLine("O numero inicial " + iCollatz.RetornaNumeroInicial(collatz) + " tem com maior sequencia de " + iCollatz.RetornaSequenciaMaior(collatz));
        }
    }
}
