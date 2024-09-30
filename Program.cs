using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaInstrumentos.Instrumentos;

namespace LojaInstrumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thykkano's Music");
            InstrumentoMusical instru1 = new  ("violão", "tagima", new DateTime(2019, 10, 10), 3000);

            Console.WriteLine(instru1);
        }
    }
}