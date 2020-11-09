using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DesignPatterns2.Contratos
{
    class Contrato
    {
        public DateTime Data { get; private set; }
        public string Cliente { get; private set; }
        public TipoContrato Tipo { get; private set; }

        public Contrato(DateTime data, string cliente, TipoContrato tipo)
        {
            Data = data;
            Cliente = cliente;
            Tipo = tipo;
        }

        public void Avanca()
        {
            if (Tipo == TipoContrato.Novo) Tipo = TipoContrato.EmAndamento;
            else if (Tipo == TipoContrato.EmAndamento) Tipo = TipoContrato.Aprovado;
            else if (Tipo == TipoContrato.Aprovado) Tipo = TipoContrato.Finalizado;

        }

        public Estado SalvaEstado()
        {
            return new Estado(new Contrato(this.Data,this.Cliente,this.Tipo));
        }

    }
}
