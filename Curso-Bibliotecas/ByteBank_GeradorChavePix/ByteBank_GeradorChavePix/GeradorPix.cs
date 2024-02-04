using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_GeradorChavePix
{
    /// <summary>
    /// Classe que gera chaves Pix usando o formato GUID.
    /// </summary>
    public static class GeradorPix
    {

        /// <summary>
        /// Método que retorna uma chave aleatória Pix.
        /// </summary>
        /// 
        /// <returns>Retorna uma chave Pix no formato string.</returns>
        public static string GetChavePix()
        {
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Método que retorna uma lista aleatória de chaves Pix.
        /// </summary>
        /// <param name="numeroChaves">Quantidade de chaves a serem geradas.</param>
        /// <returns>Uma lista de strings de chaves Pix.</returns>
        public static List<string> GetChavesPix(int numeroChaves)
        {
            if (numeroChaves <= 0)
            {
                return null;
            }
            else
            {
                var chaves = new List<string>();
                for (int i = 0; i < numeroChaves; i++)
                {
                    chaves.Add(Guid.NewGuid().ToString());
                }

                return chaves;
            }
        }
    }
}
