using System;
using System.Collections.Generic;
using System.Linq;
using hnl.veiculos.com.br.Entities;
using hnl.veiculos.com.br.Interfaces.Repositories;
using hnl.veiculos.com.br.Interfaces.Services;
using hnl.veiculos.com.br.Repositories;

namespace hnl.veiculos.com.br.Services
{
    public class MarcaService : IMarcaService
    {
        private readonly IMarcaRepository _repository;
        public MarcaService(IMarcaRepository repository){
            _repository = repository;
        }
        
        public void delete(Guid pId)
        {
            if(pId == null) throw new Exception("Informe um Id da Marca para remover!");
            var marca = _repository.get(pId);
            _repository.delete(marca);
        }

        public Marca get(Guid pId)
        {
            if(pId == null) throw new Exception("Informe um Id da Marca para obter!");
            return _repository.get(pId);
        }

        public List<Marca> list()
        {
            return _repository.list();
        }

        public Marca post(Marca marca)
        {
            if(marca == null) throw new Exception("Informe uma Marca para adicionar!"); 
            return _repository.post(marca);
        }

        public Marca put(Marca marca)
        {
            if(marca == null) throw new Exception("Informe uma Marca para adicionar!"); 
            return _repository.put(marca);
        }
    }
}