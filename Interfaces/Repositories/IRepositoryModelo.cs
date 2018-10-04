using System.Collections.Generic;
using hnl.veiculos.com.br.Models;

namespace hnl.veiculos.com.br.Interfaces.Repositories
{
    interface IRepositoryModelo
    {
         ModeloModel get(decimal pId);
         List<ModeloModel> list();
         void put(ModeloModel modelo);
         void delete(decimal pId);
    }
}