using AutoMapper;
using hnl.veiculos.com.br.Entities;
using hnl.veiculos.com.br.ModelsDTO;
using System;
using System.Collections.Generic;

namespace hnl.veiculos.com.br.Mappers
{
    public class MappingProfile : Profile
    {        
        public MappingProfile()
        {
            CreateMap<Marca, MarcaModel>()
                .ForMember(x => x.ID, opt => opt.MapFrom(m => m.ID.ToString()));
            CreateMap<Modelo, ModeloModel>()
                .ForMember(x => x.ID, opt => opt.MapFrom(m => m.ID.ToString()))
                .ForMember(x => x.IDMARCA, opt => opt.MapFrom(m => m.IDMARCA.ToString()));

            CreateMap<MarcaModel, Marca>()
                .ForMember(x => x.ID, opt => opt.MapFrom(m => new Guid(m.ID)));
            CreateMap<ModeloModel, Modelo>()
                .ForMember(x => x.ID, opt => opt.MapFrom(m => new Guid(m.ID)))
                .ForMember(x => x.IDMARCA, opt => opt.MapFrom(m => new Guid(m.IDMARCA)));
        }
    }
}