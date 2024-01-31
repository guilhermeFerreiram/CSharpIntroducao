using ByteBank;
using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var enderecoDoArquivo = "contas.txt";
        var numeroDeBytesLidos = -1;

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var buffer = new byte[1024];

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer, numeroDeBytesLidos);
                Console.Write("");
            }

            fluxoDoArquivo.Close();

            Console.ReadLine();
        }
    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer, 0, bytesLidos);
        Console.Write(texto);

        //foreach(var meuByte in buffer)
        //{
        //    Console.Write(meuByte);
        //    Console.Write("");
        //}
    }
}