using System.Collections.Generic;
using hnl.veiculos.com.br.Entities;

namespace hnl.veiculos.com.br.Interfaces.Services
{
    interface IServiceMarca
    {
         Marca get(decimal pId);
         List<Marca> list();
         void put(Marca marca);
         void delete(decimal pId);
    }
}