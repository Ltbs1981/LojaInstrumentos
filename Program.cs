using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaInstrumentos.Enumeradores;
using LojaInstrumentos.Instrumentos;

namespace LojaInstrumentos
{
    internal static class Program
    {
        private static List<InstrumentoMusical> instrumentos = new List<InstrumentoMusical>();



        static void Main(string[] args)
        {
            Console.WriteLine("Thykkano's Music");
            int opcao = 0;
            while (opcao == 0)
            {
                Console.WriteLine("Informe o que deseja fazer\n\t 1 <- Inserir Instrumento.\t\t " +
                    "Editar instrumento -> 3 \n\t" +
                    "2 <- Exibir lista de instrumentos.\t\t " +
                    "Apagar um instrumento da lista -> 4 ");

                Menu menu = Enum.Parse<Menu>(Console.ReadLine(), true);
                Console.Clear();

                switch (menu)
                {
                    case Menu.Criar:
                        break;
                    case Menu.Ler:
                        break;
                    case Menu.Editar:
                        break;
                    case Menu.Apagar:
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\t 1 <- Para continuar.\t\t Para sair -> 2");
                opcao = int.Parse(Console.ReadLine());
                opcao = opcao > 1 ? 1 : 0;
                                }
        }

    }
}
