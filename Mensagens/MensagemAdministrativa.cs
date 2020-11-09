using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace DesignPatterns2.Mensagens
{
    class MensagemAdministrativa : IMensagem
    {
        private string Administrador;
        public IEnviador Enviador { get; set; }
        public MensagemAdministrativa(string cliente)
        {
            Administrador = cliente;
        }

        public void Envia()
        {
            this.Enviador.Enviar(this);
        }

        public string Formata()
        {
            return string.Format($"Enviando mensagem para o ADM {Administrador}");
        }
    }
}
