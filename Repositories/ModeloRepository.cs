using System;
using System.Collections.Generic;
using System.Linq;
using hnl.veiculos.com.br.Entities;
using hnl.veiculos.com.br.Interfaces.Repositories;
using hnl.veiculos.com.br.Services;

namespace hnl.veiculos.com.br.Repositories
{
    public class ModeloRepository : IModeloRepository
    {
        List<Modelo> modelos = new List<Modelo>();
        public ModeloRepository(){
            modelos.Add(new Modelo(1, 1, "Prisma 2020", "https://4.bp.blogspot.com/-7cHtB4maTyw/Wv2UOd1yW_I/AAAAAAAAFaA/ShzPpHwM7dsQN_BcWFdb2_v7-zjEiWLfACLcBGAs/s1600/novo-Prisma-2020%2B%25282%2529.jpg"));
            modelos.Add(new Modelo(2, 1, "Onix", "https://img1.icarros.com/dbimg/imgmodelo/2/2428_2.png"));
            modelos.Add(new Modelo(3, 1, "Cruze", "https://www.rydellchev.com/assets/stock/ColorMatched_01/White/640/cc_2018CHC300005_01_640/cc_2018CHC300005_01_640_G9K.jpg"));
            modelos.Add(new Modelo(4, 1, "Camaro LT in Duluth", "https://www.hendrickatlanta.com/assets/stock/colormatched_01/white/640/cc_2018chc020001_01_640/cc_2018chc020001_01_640_g7q.jpg"));

            modelos.Add(new Modelo(1, 2, "Toro 2020", "http://samamveiculos.com.br/wp-content/uploads/2016/02/toro-volcano-20.png"));
            modelos.Add(new Modelo(2, 2, "Freemont", "http://autosemotos.com/wp-content/uploads/2018/07/FREEMONT.png"));
            modelos.Add(new Modelo(3, 2, "Siena", "http://s2.glbimg.com/fekxKOHGimt5Urh7IDV9v6dnvkk=/e.glbimg.com/og/ed/f/original/2014/10/24/fiat_siena_el.png"));
            modelos.Add(new Modelo(4, 2, "Argo", "http://www.fiatauguri.com.br/assets/uploads/novos/argoW.png"));

            modelos.Add(new Modelo(1, 3, "TT", "https://content.audi.co.uk/dam/7_days/CAD/External%20Assets/TT/TT_Coupe_S-line/035.png"));
            modelos.Add(new Modelo(2, 3, "R8", "https://ae01.alicdn.com/kf/HTB1WML8PVXXXXX7XXXXq6xXFXXXN/Venda-quente-1-32-para-modelos-audi-r8-liga-cars-modelos-crian-as-toys-atacado-luxuoso.jpg_640x640.jpg"));
            modelos.Add(new Modelo(3, 3, "A5", "https://img0.icarros.com/dbimg/imgmodelo/2/984_9.png"));
            modelos.Add(new Modelo(4, 3, "A7", "http://www.autoline.com.br/images/cms//novo-audi-a7-a-caminho1.jpg"));
        }
        public void delete(decimal pId)
        {
            var modelo = get(pId);
            modelos.Remove(modelo);
        }

        public Modelo get(decimal pId)
        {
            return modelos.Where(m => m.ID == pId).FirstOrDefault();
        }

        public List<Modelo> list()
        {
            return modelos;
        }

        public Modelo put(Modelo modelo)
        {
            modelos.Add(modelo);
            return modelo;
        }

    }
}