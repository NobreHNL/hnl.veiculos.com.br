using System;
using System.ComponentModel.DataAnnotations;

namespace hnl.veiculos.com.br.ModelsDTO
{
    public class ModeloModel
    {
        public string ID { get; set; }
        [Required]
        public string NOME { get; set; }
        [Required]
        public string IMAGEM { get; set; }
        [Required]
        public string MARCA { get; set; }
        [Required]
        public string IDMARCA { get; set; }
    }
}
