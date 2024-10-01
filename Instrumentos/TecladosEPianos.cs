using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInstrumentos.Instrumentos
{
    internal class TecladosEPianos : InstrumentoMusical
    {
        public int Teclas { get; set; }
        public TecladosEPianos(string nome, string modelo, string anoFabricacao, double preco, int teclas) : base(nome, modelo, anoFabricacao, preco)
        {
            Teclas = teclas;
        }
        public override string ToString()
        {
            return base.ToString() + $"\n\t Quantidades de teclas: {Teclas}";
        }
    }
}
