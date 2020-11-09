using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace DesignPatterns2.Mensagens
{
    class MensagemCliente : IMensagem
    {
        private string Cliente;
        public IEnviador Enviador { get; set; }
        public MensagemCliente(string cliente)
        {
            Cliente = cliente;
        }

        public void Envia()
        {
            this.Enviador.Enviar(this);
        }

        public string Formata()
        {
            return string.Format($"Enviando mensagem para o Cliente {Cliente}");
        }
    }
}
