using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Calculadora
{
    class Numero : IExpressao
    {
        public int Valor { get; private set; }

        public Numero(int numero)
        {
            Valor = numero;
        }

        public int Avalia()
        {
            return Valor;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }
    }
}
