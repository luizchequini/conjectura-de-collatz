using System;
using System.Collections.Generic;
using System.Text;

namespace ConjecturaDeCollatz
{
    public class ServiceCollatz : IServiceCollatz
    {
        private readonly ICollatz _collatz;

        public ServiceCollatz()
        {
            _collatz = new RepositoryCollatz();
        }

        public void CalculoDeCollatz(int x, Collatz collatz)
        {
            int i;
            int numeroCalculado;
            int numeroInicial;
            int numeracaoRegressiva = x;

            while (numeracaoRegressiva > 1)
            {
                i = 0;
                numeroCalculado = numeracaoRegressiva--;
                numeroInicial = numeroCalculado;

                while (numeroCalculado > 1)
                {
                    i++;
                    numeroCalculado = numeroCalculado % 2 == 0 ? numeroCalculado / 2 : 3 * numeroCalculado + 1;
                }

                if (i > _collatz.RetornaSequenciaMaior(collatz))
                {
                    collatz.numeroInicial = numeroInicial;
                    collatz.sequenciaMaior = ++i;
                }
            }

        }
    }
}
