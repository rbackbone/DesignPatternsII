using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Pedidos
{
    class FinalizaPedido : IComando
    {
        private Pedido _pedido;

        public FinalizaPedido(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine($"Finalizando pedido {_pedido.Cliente }");
            _pedido.Finaliza();
        }
    }
}
