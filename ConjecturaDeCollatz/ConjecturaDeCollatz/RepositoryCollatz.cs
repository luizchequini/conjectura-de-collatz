using System;
using System.Collections.Generic;
using System.Text;

namespace ConjecturaDeCollatz
{
    public class RepositoryCollatz : RepositoryGenerics<Collatz>, ICollatz
    {
        public int RetornaSequenciaMaior(Collatz collatz)
        {
            return collatz.sequenciaMaior;
        }

        public int RetornaNumeroInicial(Collatz collatz)
        {
            return collatz.numeroInicial;
        }
    }
}
