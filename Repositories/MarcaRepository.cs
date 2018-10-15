using System;
using System.Collections.Generic;
using hnl.veiculos.com.br.Entities;
using hnl.veiculos.com.br.Services;
using hnl.veiculos.com.br.Interfaces.Repositories;
using System.Linq;
using hnl.veiculos.com.br.Data;

namespace hnl.veiculos.com.br.Repositories
{
    public class MarcaRepository : IMarcaRepository
    {        
        protected readonly AppDbContext _context;
        public MarcaRepository(AppDbContext context){            
            _context = context;
        }
        public void delete(Guid pId)
        {
            var marca = get(pId);
            _context.Marca.Remove(marca);
        }

        public Marca get(Guid pId)
        {   
            return _context.Marca.Where(m => m.ID == pId).FirstOrDefault();
        }

        public List<Marca> list()
        {
            return _context.Marca.ToList();
        }

        public Marca put(Marca marca)
        {
            _context.Marca.Update(marca);
            return marca;
        }
    }
}