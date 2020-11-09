using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Contratos
{
    class Historico
    {
        private IList<Estado> Estados = new List<Estado>();
        public int Total { get; private set; }
        public void Adiciona(Estado estado)
        {
            this.Estados.Add(estado);
            Total++;
        }

        public Estado Get(int indice)
        {
            return Estados[indice];
        }
    }
}
