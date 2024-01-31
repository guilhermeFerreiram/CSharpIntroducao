using ByteBank;
using System.Text;

partial class Program
{
    static void StreamDeEntrada()
    {
        using (var fluxoDoArquivo = Console.OpenStandardInput())
        using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
        {
            var buffer = new byte[1024];

            while (true)
            {
                var bytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

                fs.Write(buffer, 0, bytesLidos);
                fs.Flush();

                Console.WriteLine($"Quantidade de bytes lidos: {bytesLidos}");
            }


        }
    }
}