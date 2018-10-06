using AutoMapper;
using hnl.veiculos.com.br.Entities;
using hnl.veiculos.com.br.Models;

namespace hnl.veiculos.com.br.Mappers
{
    public class MappingProfile : Profile
    {
        
        public MappingProfile()
        {
            CreateMap<Marca, MarcaModel>();
            CreateMap<MarcaModel, Marca>();            
        }        
    }
}