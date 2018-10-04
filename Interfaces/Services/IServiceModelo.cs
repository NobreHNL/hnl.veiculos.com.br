using System.Collections.Generic;
using hnl.veiculos.com.br.Entities;

namespace hnl.veiculos.com.br.Interfaces.Services
{
    interface IServiceModelo
    {
        Modelo get(decimal pId);
        List<Modelo> list();
        void put(Modelo modelo);
        void delete(decimal pId);
    }
}