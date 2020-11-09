using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Pedidos
{
    class PagaPedido : IComando
    {
        private Pedido _pedido;

        public PagaPedido(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine($"Pagando pedido {_pedido.Cliente }");
            _pedido.Paga();            
        }
    }
}
