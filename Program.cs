using System;
using System.Collections.Generic;
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
                        CadastroMenu();
                        break;
                    case Menu.Ler:
                        ImprimeDados();
                        break;
                    case Menu.Editar:
                        EditarInstrumento();
                        break;
                    case Menu.Apagar:
                        RemoverInstrumento();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Deseja continuar ? 1) Sim = 2) Não");
                opcao = int.Parse(Console.ReadLine());
                opcao = opcao > 1 ? 1 : 0;
            }
        }

        public static void CadastroMenu()
        {
            Console.WriteLine("Selecione o tipo de instrumento que deseja cadastrar:");
            Console.WriteLine("\t1) Instrumento qualquer\n\t2) Guitarra\n\t3) Teclado ou Piano");

            MenuTipoInstrumentos tipoInstrumento = Enum.Parse<MenuTipoInstrumentos>(Console.ReadLine(), true);

            switch (tipoInstrumento)
            {
                case MenuTipoInstrumentos.InstrumentoSemGrupo:
                    CadastroGuitarra();
                    break;
                case MenuTipoInstrumentos.Guitarra:
                    CadastroTecladoOuPiano();
                    break;
                case MenuTipoInstrumentos.TecladoOuPiano:
                    CadastroInstrumentoGenerico();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        public static void CadastroInstrumentoGenerico()
        {
            Console.WriteLine("Informe o nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o modelo:");
            string modelo = Console.ReadLine();
            Console.WriteLine("Informe o ano de fabricação:");
            string anoFabricacao = Console.ReadLine();
            Console.WriteLine("Informe o preço:");
            double preco = double.Parse(Console.ReadLine());

            InstrumentoMusical instrumento = new InstrumentoMusical(nome, modelo, anoFabricacao, preco);
            instrumentos.Add(instrumento);
        }

        public static void CadastroGuitarra()
        {
            Console.WriteLine("Informe o nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o modelo:");
            string modelo = Console.ReadLine();
            Console.WriteLine("Informe o ano de fabricação:");
            string anoFabricacao = Console.ReadLine();
            Console.WriteLine("Informe o preço:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o tipo do braço:");
            string tipoBraco = Console.ReadLine();
            Console.WriteLine("Informe o tipo do corpo:");
            string tipoCorpo = Console.ReadLine();
            Console.WriteLine("Selecione o estilo:");
            Estilo estilo = Enum.Parse<Estilo>(Console.ReadLine(), true);
            Console.WriteLine("Selecione o captador:");
            Captadores captadores = Enum.Parse<Captadores>(Console.ReadLine(), true);

            Guitarra guitarra = new Guitarra(nome, modelo, anoFabricacao, preco, tipoBraco, tipoCorpo, estilo, captadores);
            instrumentos.Add(guitarra);
        }

        public static void CadastroTecladoOuPiano()
        {
            Console.WriteLine("Informe o nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o modelo:");
            string modelo = Console.ReadLine();
            Console.WriteLine("Informe o ano de fabricação:");
            string anoFabricacao = Console.ReadLine();
            Console.WriteLine("Informe o preço:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de teclas:");
            int teclas = int.Parse(Console.ReadLine());

            TecladosEPianos teclado = new TecladosEPianos(nome, modelo, anoFabricacao, preco, teclas);
            instrumentos.Add(teclado);
        }


        public static void ImprimeDados()
        {
            if (instrumentos.Count == 0)
            {
                Console.WriteLine("Nenhum instrumento cadastrado.");
            }
            else
            {
                foreach (var instrumento in instrumentos)
                {
                    Console.WriteLine(instrumento.ToString());
                }
            }
        }

        public static void EditarInstrumento()
        {
            ImprimeDados();

            Console.WriteLine("Informe o ID do instrumento que deseja editar:");
            int id = int.Parse(Console.ReadLine());
            InstrumentoMusical instrumento = instrumentos.FirstOrDefault(i => i.Id == id);

            if (instrumento != null)
            {
                Console.WriteLine("Informe o novo nome:");
                instrumento.Nome = Console.ReadLine();
                Console.WriteLine("Informe o novo modelo:");
                instrumento.Modelo = Console.ReadLine();
                Console.WriteLine("Informe o novo ano de fabricação:");
                instrumento.AnoFabricacao = Console.ReadLine();
                Console.WriteLine("Informe o novo preço:");
                instrumento.Preco = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Instrumento não encontrado.");
            }
        }

        public static void RemoverInstrumento()
        {
            ImprimeDados();

            Console.WriteLine("Informe o ID do instrumento que deseja remover:");
            int id = int.Parse(Console.ReadLine());
            InstrumentoMusical instrumento = instrumentos.FirstOrDefault(i => i.Id == id);

            if (instrumento != null)
            {
                instrumentos.Remove(instrumento);
                Console.WriteLine("Instrumento removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Instrumento não encontrado.");
            }
        }
    }
}
