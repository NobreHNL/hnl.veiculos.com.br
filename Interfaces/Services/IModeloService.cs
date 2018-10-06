using System.Collections.Generic;
using hnl.veiculos.com.br.Entities;

namespace hnl.veiculos.com.br.Interfaces.Services
{
    interface IModeloService
    {
        Modelo get(decimal pId);
        List<Modelo> list();
        Modelo put(Modelo modelo);
        void delete(decimal pId);
    }
}