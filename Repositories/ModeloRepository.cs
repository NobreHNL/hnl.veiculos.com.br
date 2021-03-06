using System;
using System.Collections.Generic;
using System.Linq;
using hnl.veiculos.com.br.Data;
using hnl.veiculos.com.br.Entities;
using hnl.veiculos.com.br.Interfaces.Repositories;
using hnl.veiculos.com.br.Services;

namespace hnl.veiculos.com.br.Repositories
{
    public class ModeloRepository : IModeloRepository
    {
        protected readonly DataContext _context;
        public ModeloRepository(DataContext context){           
            _context = context;
        }
        
        public void delete(Modelo modelo)
        {
            _context.Remove(modelo);
            _context.SaveChanges();
        }

        public Modelo get(Guid pId)
        {
            return _context.Modelo.Where(m => m.ID == pId).FirstOrDefault();
        }

        public List<Modelo> getById(Guid pId)
        {
            return _context.Modelo.Where(m => m.IDMARCA == pId).ToList();
        }

        public List<Modelo> list()
        {
            return _context.Modelo.ToList();
        }

        public Modelo put(Modelo modelo)
        {
            _context.Update(modelo);
            _context.SaveChanges();
            return modelo;
        }

        public Modelo post(Modelo modelo)
        {
            _context.Add(modelo);
            _context.SaveChanges();
            return modelo;
        }
    }
}