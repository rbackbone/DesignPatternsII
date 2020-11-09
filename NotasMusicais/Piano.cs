using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2
{
    class Piano
    {
        public void Tocar(IList<INota> musica)
        {
            foreach (var nota in musica)
            {
                Console.Beep(nota.Frequencia, 300);
            }

        }
    }
}
