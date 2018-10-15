using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using hnl.veiculos.com.br.Controllers.Base;
using hnl.veiculos.com.br.Interfaces.Services;
using hnl.veiculos.com.br.Models;
using Microsoft.AspNetCore.Mvc;

namespace hnl.veiculos.com.br.Controllers
{
    [Route("api/[controller]")]
    public class ModeloController: BaseController
    {
        private readonly IMapper _mapper;
        private readonly IModeloService _service;

        public ModeloController(IMapper mapper, IModeloService service)
        {
            _mapper=mapper;
            _service=service;
        }
        
        [HttpGet("[action]")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<List<ModeloModel>>> GetModeloByMarcaId(Guid pId)
        {
            var modelo = _service.getById(pId);
            
            if(modelo == null) return NotFound();

            var response = _mapper.Map<List<ModeloModel>>(modelo);
            return await Task.FromResult(response);
        }
    }
}