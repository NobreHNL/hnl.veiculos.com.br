using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using hnl.veiculos.com.br.Models;
using hnl.veiculos.com.br.Services;
using hnl.veiculos.com.br.Interfaces.Services;
using hnl.veiculos.com.br.Mappers;
using System.Threading.Tasks;
using System.Net.Http;
using System;
using System.Net;
using hnl.veiculos.com.br.Controllers.Base;
using hnl.veiculos.com.br.Entities;

namespace hnl.veiculos.com.br.Controllers
{
    [Route("api/[controller]")]
    public class MarcaController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IMarcaService _service;
        public MarcaController(IMapper mapper, IMarcaService service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<MarcaModel>> CreateMarca(MarcaModel marca){            
                                  
            var _marca = new Marca(Guid.NewGuid(), marca.NOME, marca.IMAGEM);
            _service.post(_marca);

            return await Task.FromResult(CreatedAtAction(nameof(GetMarcaById), new {id = _marca.ID}, _marca));
        }

        [HttpGet("[action]")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<MarcaModel>> GetMarcaById(Guid pId)
        {            
            var marca = _service.get(pId);
            
            if(marca == null) return NotFound();

            var response = _mapper.Map<MarcaModel>(marca);
            return await Task.FromResult(response);
        }

        [HttpGet("[action]")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<List<MarcaModel>>> ListMarcas()
        {            
            var response = _mapper.Map<List<MarcaModel>>(_service.list());
            return await Task.FromResult(response);
        }

        [HttpDelete("[action]")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> DeleteMarca(Guid pId)
        {
            _service.delete(pId);
            return await Task.FromResult(NoContent());
        }

        [HttpPut("[action]")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<MarcaModel>> UpdateMarca(MarcaModel marca){            
            _service.put(_mapper.Map<Marca>(marca));

            return await Task.FromResult(CreatedAtAction(nameof(GetMarcaById), new {id = marca.ID}, marca));
        }
    }
}