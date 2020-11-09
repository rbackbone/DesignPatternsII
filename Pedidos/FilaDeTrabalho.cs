using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Pedidos
{
    class FilaDeTrabalho
    {
        IList<IComando> Comandos = new List<IComando>();

        public void Adiciona(IComando comando)
        {
            this.Comandos.Add(comando);
        }

        public void Processa()
        {
            foreach (var comando in this.Comandos)
            {
                comando.Executa();
            }

        }
    }
}
