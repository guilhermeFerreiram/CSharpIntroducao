using ByteBank;
using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "465, 7895, 4785.40, Gustavo Santos";

            var enconding = Encoding.UTF8;

            var bytes = enconding.GetBytes(contaComoString);

            fluxoDoArquivo.Write(bytes, 0, bytes.Length);
        }
    }

    static void CriandoArquivoComWriter()
    {
        var caminhoDoArquivo = "contasExportadasComWriter.csv";

        using (var fluxoDoArquivo = new FileStream(caminhoDoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDoArquivo))
        {
            escritor.Write("465,7895,4785.40,Gustavo Santos");
        }
    }

    static void TestaEscrita()
    {
        var caminhoDoArquivo = "teste.txt";

        using (var fluxoDoArquivo = new FileStream(caminhoDoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDoArquivo))
        {
            for (int i = 0; i < 1000000; i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush(); //Despeja o buffer para o stream
                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle Enter...");
                Console.ReadLine();
            }
        }
    }
}
