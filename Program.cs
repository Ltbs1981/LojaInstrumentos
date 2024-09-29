using LojaInstrumentos.Instrumentos;

static void Main (string[] args)
{
    InstrumentoMusical violao = new("Violão Tagima", "Califórnnia", new DateTime(2019, 10, 10), 2500);

    Console.WriteLine(violao.Nome);
}