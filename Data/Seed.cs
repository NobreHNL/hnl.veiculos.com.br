using hnl.veiculos.com.br.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hnl.veiculos.com.br.Data
{
    public class Seed
    {
        private readonly DataContext _context;

        public Seed(DataContext context)
        {
            _context = context;
        }

        public void SeedMarcasModelos()
        {
            var chevroletId = Guid.NewGuid();
            var fiatId = Guid.NewGuid();
            var auditId = Guid.NewGuid();

            _context.Marca.Add(new Marca(chevroletId, "Chevrolet", "https://upload.wikimedia.org/wikipedia/pt/thumb/3/34/Chevrolet_logo.png/250px-Chevrolet_logo.png"));
            _context.Marca.Add(new Marca(fiatId, "Fiat", "https://upload.wikimedia.org/wikipedia/en/thumb/9/96/Fiat_Logo.svg/1200px-Fiat_Logo.svg.png"));
            _context.Marca.Add(new Marca(auditId, "Audi", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7f/Audi_logo_detail.svg/200px-Audi_logo_detail.svg.png"));

            _context.Modelo.Add(new Modelo(Guid.NewGuid(), chevroletId, "Prisma 2020", "Chevrolet", "https://4.bp.blogspot.com/-7cHtB4maTyw/Wv2UOd1yW_I/AAAAAAAAFaA/ShzPpHwM7dsQN_BcWFdb2_v7-zjEiWLfACLcBGAs/s1600/novo-Prisma-2020%2B%25282%2529.jpg"));
            _context.Modelo.Add(new Modelo(Guid.NewGuid(), chevroletId, "Onix", "Chevrolet", "https://img1.icarros.com/dbimg/imgmodelo/2/2428_2.png"));
            _context.Modelo.Add(new Modelo(Guid.NewGuid(), chevroletId, "Cruze", "Chevrolet", "https://www.rydellchev.com/assets/stock/ColorMatched_01/White/640/cc_2018CHC300005_01_640/cc_2018CHC300005_01_640_G9K.jpg"));
            _context.Modelo.Add(new Modelo(Guid.NewGuid(), chevroletId, "Camaro LT in Duluth", "Chevrolet", "https://www.hendrickatlanta.com/assets/stock/colormatched_01/white/640/cc_2018chc020001_01_640/cc_2018chc020001_01_640_g7q.jpg"));

            _context.Modelo.Add(new Modelo(Guid.NewGuid(), fiatId, "Toro 2020", "Fiat", "http://samamveiculos.com.br/wp-content/uploads/2016/02/toro-volcano-20.png"));
            _context.Modelo.Add(new Modelo(Guid.NewGuid(), fiatId, "Freemont", "Fiat", "http://autosemotos.com/wp-content/uploads/2018/07/FREEMONT.png"));
            _context.Modelo.Add(new Modelo(Guid.NewGuid(), fiatId, "Siena", "Fiat", "http://s2.glbimg.com/fekxKOHGimt5Urh7IDV9v6dnvkk=/e.glbimg.com/og/ed/f/original/2014/10/24/fiat_siena_el.png"));
            _context.Modelo.Add(new Modelo(Guid.NewGuid(), fiatId, "Argo", "Fiat", "http://www.fiatauguri.com.br/assets/uploads/novos/argoW.png"));

            _context.Modelo.Add(new Modelo(Guid.NewGuid(), auditId, "TT", "Audi", "https://content.audi.co.uk/dam/7_days/CAD/External%20Assets/TT/TT_Coupe_S-line/035.png"));
            _context.Modelo.Add(new Modelo(Guid.NewGuid(), auditId, "R8", "Audi", "https://ae01.alicdn.com/kf/HTB1WML8PVXXXXX7XXXXq6xXFXXXN/Venda-quente-1-32-para-modelos-audi-r8-liga-cars-modelos-crian-as-toys-atacado-luxuoso.jpg_640x640.jpg"));
            _context.Modelo.Add(new Modelo(Guid.NewGuid(), auditId, "A5", "Audi", "https://img0.icarros.com/dbimg/imgmodelo/2/984_9.png"));
            _context.Modelo.Add(new Modelo(Guid.NewGuid(), auditId, "A7", "Audi", "http://www.autoline.com.br/images/cms//novo-audi-a7-a-caminho1.jpg"));

            _context.SaveChanges();
        }
    }
}
