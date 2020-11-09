using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Contratos
{
    class Estado
    {
        public Estado(Contrato contrato)
        {
            Contrato = contrato;
        }

        public Contrato Contrato { get; private set; }

    }
}
