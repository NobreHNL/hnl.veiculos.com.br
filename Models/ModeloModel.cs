using System;

namespace hnl.veiculos.com.br.Models
{
    public class ModeloModel
    {
        public Guid ID { get; private set; }
        public string NOME { get; private set; }
        public string IMAGEM { get; private set; }
        public string MARCA { get; private set; }
        public Guid IDMARCA { get; private set; }
    }
}
