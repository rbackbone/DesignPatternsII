using System;
using DesignPatterns2.Contratos;
using System.Collections.Generic;
using DesignPatterns2.Calculadora;
using System.Linq.Expressions;
using DesignPatterns2.Mensagens;
using DesignPatterns2.Pedidos;
using DesignPatterns2.Bibliotecas;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns II");


            Console.WriteLine("Flyweight Pattern - vários objetos, sem repetir instâncias de mesmo tipo");
            NotasMusicais notas = new NotasMusicais();
            IList<INota> musica = new List<INota>() {
                notas.Get("do"),
                notas.Get("re"),
                notas.Get("mi"),
                notas.Get("fa"),
                notas.Get("fa"),
                notas.Get("fa"),
                notas.Get("fa")
            };

            Piano piano = new Piano();
            piano.Tocar(musica);

            Console.WriteLine("----------------------------------------------------------------\n");
            Console.WriteLine("Memento Pattern - Salvar estados de objetos (possibilita desfazer ações)");
            Historico historico = new Historico();
            Contrato c = new Contrato(DateTime.Now,"RMac Hambone Life Solve",TipoContrato.Novo);
            historico.Adiciona(c.SalvaEstado());
            c.Avanca();
            historico.Adiciona(c.SalvaEstado());
            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            for (int i = 0; i <= historico.Total-1; i++)
            {
                Console.WriteLine($"Histórico contrato {i} : {historico.Get(i).Contrato.Tipo} ");
            }
            Console.WriteLine("----------------------------------------------------------------\n");
            Console.WriteLine("Interpeter Pattern - árvore de expressões");

            IExpressao esquerda = new Soma(new Numero(2), new Numero(32));
            IExpressao direita = new Subtracao(new Numero(77), new Numero(18));
            IExpressao soma = new Soma(direita, esquerda);
            Console.WriteLine($"Resultado expressão: {soma.Avalia()}");

            Console.WriteLine("Interpeter nativo do C# (na verdade a linguagem usa para interpretar praticamente tudo)");
            Expression newSoma = Expression.Add(Expression.Constant(10), Expression.Constant(75));
            Func<int> funcao = Expression.Lambda<Func<int>>(newSoma).Compile();

            Console.WriteLine("----------------------------------------------------------------\n");
            Console.WriteLine("Visitor Pattern - visitar cadas um dos nós da árvore de expressões");

            Impressora impressora = new Impressora();
            soma.Aceita(impressora);

            Console.WriteLine("----------------------------------------------------------------\n");
            Console.WriteLine("Bridge Pattern - separando responsabilidades entre duas hierarquias de classes");

            IMensagem mensagem = new MensagemCliente("RMac Hambone");
            IEnviador enviador = new EnviaEmail();
            mensagem.Enviador = enviador;
            mensagem.Envia();
            IMensagem mensagemAdm = new MensagemAdministrativa("RMac Hambone");
            mensagemAdm.Enviador = new EnviaSMS();
            mensagemAdm.Envia();

            Console.WriteLine("----------------------------------------------------------------\n");
            Console.WriteLine("Command Pattern - guardar comandos (ações) para execução posterior");

            FilaDeTrabalho fila = new FilaDeTrabalho();
            Pedido pedido1 = new Pedido("Mac Hambone", 100.4);
            Pedido pedido2 = new Pedido("Mac TroisF", 200.4);
            Pedido pedido3 = new Pedido("Mac Judge", 130.4);
            Pedido pedido4 = new Pedido("Mac Doc Antle", 1100.4);
            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));
            fila.Adiciona(new FinalizaPedido(pedido2));
            fila.Adiciona(new PagaPedido(pedido3));
            fila.Adiciona(new FinalizaPedido(pedido4));

            fila.Processa();


            Console.WriteLine("----------------------------------------------------------------\n");
            Console.WriteLine("Adapter Pattern - isolar o código de uma biblioteca ou sistema legado");
            Console.WriteLine("                - semelhante ao Command ou Strategy - a diferenã está no propósito");
            Console.WriteLine("                - a finalidade aqui é Adaptar uma implementação ao meu sistema");

            Cliente cliente = new Cliente();
            cliente.Nome = "Mac Hambone";
            cliente.Endereco = "Rua Sete Ventos";
            cliente.DataNascimento = DateTime.Now;

            string xml = new GeradorDeXml().GeraXML(cliente);

            Console.WriteLine(xml);

            Console.WriteLine("\n\nPress any key to exit . . .");
            Console.ReadKey();
        }
    }
}
