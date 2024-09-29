using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInstrumentos.Instrumentos
{
    internal class InstrumentoMusical
    {
        public static int id;

        private int _id;

        public int Id
        { get { return _id; } }
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public double Preco { get; set; }
        public bool ProntaEntrega { get; set; }

        public InstrumentoMusical()
        {
            id++;
            _id = id;
        }

        public InstrumentoMusical(string nome, string modelo, DateTime anoFabricacao, double preco) : this ()
        {
            Nome = nome;
            Modelo = modelo;
            AnoFabricacao = anoFabricacao;
            Preco = preco;
            ProntaEntrega = true;
        }
    }
}
