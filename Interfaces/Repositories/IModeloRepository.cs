using System.Collections.Generic;
using hnl.veiculos.com.br.Entities;

namespace hnl.veiculos.com.br.Interfaces.Repositories
{
    public interface IModeloRepository
    {
         Modelo get(decimal pId);
         List<Modelo> list();
         Modelo put(Modelo modelo);
         void delete(decimal pId);
        List<Modelo> getById(decimal pId);
    }
}