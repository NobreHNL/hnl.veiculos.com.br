using System.Collections.Generic;
using hnl.veiculos.com.br.Entities;

namespace hnl.veiculos.com.br.Interfaces.Services
{
    public interface IMarcaService
    {
         Marca get(decimal pId);
         List<Marca> list();
         Marca put(Marca marca);
         void delete(decimal pId);
    }
}