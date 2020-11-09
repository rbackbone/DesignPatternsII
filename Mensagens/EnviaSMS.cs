using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Mensagens
{
    class EnviaSMS : IEnviador
    {
        public void Enviar(IMensagem mensagem)
        {
            Console.WriteLine("Enviando por SMS ...");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
