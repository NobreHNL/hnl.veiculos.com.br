using System;
using System.ComponentModel.DataAnnotations;

namespace hnl.veiculos.com.br.ModelsDTO
{
    public class MarcaModel
    {
        public string ID {get; set; }
        [Required]
        public string IMAGEM { get; set; }
        [Required]
        public string NOME {get; set;}

        public MarcaModel(string Nome, string Imagem)
        {
            this.NOME = Nome;
            this.IMAGEM = Imagem;
        }
    }
}