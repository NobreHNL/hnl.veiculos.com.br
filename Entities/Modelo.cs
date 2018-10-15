using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hnl.veiculos.com.br.Entities
{
    [Table("Modelos")]
    public class Modelo
    {
        public Guid ID { get; private set; }
        [Required][StringLength(255)]
        public string NOME { get; private set; }
        public string IMAGEM { get; private set; }
        public string MARCA { get; private set; }
        public Guid IDMARCA { get; private set; }

        // public Modelo(Guid pId, Guid pIdMarca, string Nome, string Marca, string Imagem){
        //     this.ID = pId;
        //     this.IDMARCA = pIdMarca;
        //     this.NOME = Nome;
        //     this.IMAGEM = Imagem;
        //     this.MARCA = Marca;
        // }
    }
}
