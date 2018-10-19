using System;
using System.Collections.Generic;
using hnl.veiculos.com.br.Entities;

namespace hnl.veiculos.com.br.Interfaces.Repositories
{
    public interface IModeloRepository
    {
         Modelo get(Guid pId);
         List<Modelo> list();
         Modelo put(Modelo modelo);
         Modelo post(Modelo modelo);
         void delete(Guid pId);         
         List<Modelo> getById(Guid pId);
    }
}