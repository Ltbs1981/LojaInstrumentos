using LojaInstrumentos.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaInstrumentos.Instrumentos;

namespace LojaInstrumentos.Instrumentos
{
    internal class Guitarra : InstrumentoMusical
    {

        public string TipoDoBraco { get; set; }
        public string TipoDoCorpo { get; set; }
        public Captadores Captadores { get; set; }
        public Estilo Estilo { get; set; }

        public Guitarra(string nome, string modelo, string anoFabricacao, double preco, string tipoDoBraco, string tipoDoCorpo, Estilo estilo, Captadores captadores ) : base(nome, modelo, anoFabricacao, preco)
        {
            TipoDoBraco = tipoDoBraco;
            TipoDoCorpo = tipoDoCorpo;
            Estilo = estilo;
            Captadores = captadores;
        }

        public override string ToString()
        {
            return base.ToString() + $"\n\t Tipo do braço: {TipoDoBraco}\n\t Tipo do corpo: {TipoDoCorpo}\n\tEstilo: {Estilo}\n\t Tipo do Captador: {Captadores}";
        }
    }
}