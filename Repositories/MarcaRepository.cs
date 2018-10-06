using System;
using System.Collections.Generic;
using hnl.veiculos.com.br.Entities;
using hnl.veiculos.com.br.Services;
using hnl.veiculos.com.br.Interfaces.Repositories;
using System.Linq;

namespace hnl.veiculos.com.br.Repositories
{
    public class MarcaRepository : IMarcaRepository
    {        
        List<Marca> marcas; 
        public MarcaRepository(){            
            marcas = new List<Marca>();
            marcas.Add(new Marca(1, "Chevrolet", "https://upload.wikimedia.org/wikipedia/pt/thumb/3/34/Chevrolet_logo.png/250px-Chevrolet_logo.png"));
            marcas.Add(new Marca(2, "Fiat", "https://upload.wikimedia.org/wikipedia/en/thumb/9/96/Fiat_Logo.svg/1200px-Fiat_Logo.svg.png"));
            marcas.Add(new Marca(3, "Audi", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7f/Audi_logo_detail.svg/200px-Audi_logo_detail.svg.png"));
        }
        public void delete(decimal pId)
        {
            var marca = get(pId);
            marcas.Remove(marca);
        }

        public Marca get(decimal pId)
        {   
            return marcas.Where(m => m.ID == pId).FirstOrDefault();
        }

        public List<Marca> list()
        {
            return marcas;
        }

        public Marca put(Marca marca)
        {
            marcas.Add(marca);
            return marca;
        }
    }
}