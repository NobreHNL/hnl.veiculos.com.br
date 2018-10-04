using System.Collections.Generic;
using hnl.veiculos.com.br.Models;

namespace hnl.veiculos.com.br.Interfaces.Repositories
{
    interface IRepositoryMarca
    {
        MarcaModel get(decimal pId);
        List<MarcaModel> list();
        void put(MarcaModel marca);
        void delete(decimal pId);
    }
}