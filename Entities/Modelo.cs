using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hnl.veiculos.com.br.Entities
{
    [Table("Modelos")]
    public class Modelo
    {
        public decimal ID { get; private set; }
        [Required][StringLength(255)]
        public string NOME { get; private set; }
        public string IMAGEM { get; private set; }
        public Marca MARCA { get; private set; }
        public decimal IDMARCA { get; private set; }

        public Modelo(decimal pId, decimal pIdMarca, string Nome, string Imagem){
            this.ID = pId;
            this.IDMARCA = pIdMarca;
            this.NOME = Nome;
            this.IMAGEM = Imagem;
        }
    }
}
