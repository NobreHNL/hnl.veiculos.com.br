using System;

namespace hnl.veiculos.com.br.Models
{
    public class MarcaModel
    {
        public Guid ID {get; set; }
        public string IMAGEM { get; set; }
        public string NOME {get; set;}

        public MarcaModel(string Nome, string Imagem)
        {
            this.NOME = Nome;
            this.IMAGEM = Imagem;
        }
    }
}