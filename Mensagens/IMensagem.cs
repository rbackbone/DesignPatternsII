using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace DesignPatterns2.Mensagens
{
    interface IMensagem
    {
        public IEnviador Enviador { get; set; }
        public void Envia();

        string Formata();

    }
}
