using System;
using System.Collections.Generic;
using System.Linq;
using hnl.veiculos.com.br.Entities;
using hnl.veiculos.com.br.Interfaces.Repositories;
using hnl.veiculos.com.br.Interfaces.Services;

namespace hnl.veiculos.com.br.Services
{
    public class ModeloService: IModeloService
    {        
        private readonly IModeloRepository _repository;
        public ModeloService(IModeloRepository repository)
        {
            _repository = repository;
        }
        public void delete(Guid pId)
        {
            if(pId == null) throw new Exception("Informe um Id do Modelo para remover!");
            _repository.delete(pId);
        }

        public Modelo get(Guid pId)
        {
            if(pId == null) throw new Exception("Informe um Id do Modelo para obter!");
            return _repository.get(pId);
        }

        public List<Modelo> getById(Guid pId)
        {
            if(pId == null) throw new Exception("Informe um Id do Modelo para obter!");
            return _repository.getById(pId);
        }

        public List<Modelo> list()
        {
            return _repository.list();
        }

        public Modelo put(Modelo modelo)
        {
            if(modelo == null) throw new Exception("Informe um Modelo para adicionar!"); 
            return _repository.put(modelo);
        }
    }
}