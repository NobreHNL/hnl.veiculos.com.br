using System;
using System.Collections.Generic;
using hnl.veiculos.com.br.Interfaces.Repositories;
using hnl.veiculos.com.br.Models;
using hnl.veiculos.com.br.Services;

namespace hnl.veiculos.com.br.Repositories
{
    public class RepositoryMarca : IRepositoryMarca
    {
        private static ServiceMarca _service;

        public RepositoryMarca(ServiceMarca service){
            _service = service;
        }

        public void delete(decimal pId)
        {
            if(pId == 0) throw new Exception("Informe um Id da Marca para remover!");

            _service.delete(pId);
        }

        public MarcaModel get(decimal pId)
        {
            if(pId == 0) throw new Exception("Informe um Id da Marca para obter!");
            return _service.get(pId);
        }

        public List<MarcaModel> list()
        {
            return _service.list();
        }

        public void put(MarcaModel marca)
        {
            if(marca == null) throw new Exception("Informe uma Marca para adicionar!"); 
            _service.put(marca);
        }
    }
}