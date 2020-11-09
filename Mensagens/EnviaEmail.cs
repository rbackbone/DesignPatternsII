using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Mensagens
{
    class EnviaEmail : IEnviador
    {
        public void Enviar(IMensagem mensagem)
        {
            Console.WriteLine("Enviando por e-mail ...");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
