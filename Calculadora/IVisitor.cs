using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Calculadora
{
/// <summary>
///        implementar através de Interface possibilita para quem implementar
///        o IVisitor poder customizar a forma de exibir as expressões
/// </summary>
    interface IVisitor
    {
        public void ImprimeSoma(Soma soma);
        public void ImprimeSubtracao(Subtracao subtracao);
        public void ImprimeNumero(Numero numero);
    }
}
