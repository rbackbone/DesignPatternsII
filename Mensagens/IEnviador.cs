using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Mensagens
{
    interface IEnviador
    {
        public void Enviar(IMensagem mensagem);
    }
}
