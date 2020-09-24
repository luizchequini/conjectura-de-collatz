using System;
using System.Collections.Generic;
using System.Text;

namespace ConjecturaDeCollatz
{
    public interface ICollatz : IGeneric<Collatz>
    {
        int RetornaNumeroInicial(Collatz collatz);

        int RetornaSequenciaMaior(Collatz collatz);
    }
}
