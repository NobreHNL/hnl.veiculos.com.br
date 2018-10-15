using System;
using System.Collections.Generic;
using hnl.veiculos.com.br.Entities;

namespace hnl.veiculos.com.br.Interfaces.Repositories
{
    public interface IMarcaRepository
    {
        Marca get(Guid pId);
        List<Marca> list();
        Marca put(Marca marca);
        void delete(Guid pId);
    }
}