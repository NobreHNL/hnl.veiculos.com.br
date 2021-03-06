using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace hnl.veiculos.com.br.Entities
{
    public class Marca
    {
        public Guid ID {get; private set; }
        [Required][StringLength(255)]
        public string IMAGEM { get; private set; }
        public string NOME {get; private set;}
        public ICollection<Modelo> MODELOS {get; private set;}
        public Marca()
        {
            MODELOS = new Collection<Modelo>();
        }

        public Marca(Guid Id, string Nome, string Imagem){
            this.ID = Id;
            this.NOME = Nome;
            this.IMAGEM = Imagem;
        }
    }
}