using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Calculadora
{
    interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor impressora);
    }
}
