using ControleBar.ConsoleApp.Compartilhado;
using System;

namespace ControleBar.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public int NumeroDaMesa { get; set; }

        public Mesa(int numeroDaMesa)
        {
            NumeroDaMesa = numeroDaMesa;
        }

        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Numero da Mesa: " + NumeroDaMesa + Environment.NewLine;
        }



    }
}
