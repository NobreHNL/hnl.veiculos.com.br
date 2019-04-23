using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using hnl.veiculos.com.br.Controllers.Base;
using hnl.veiculos.com.br.Entities;
using hnl.veiculos.com.br.Interfaces.Services;
using hnl.veiculos.com.br.ModelsDTO;
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

        [HttpPost("[action]")]
        public async Task<ActionResult<ModeloModel>> CreateModelo(ModeloModel modelo)
        {

            var _modelo = new Modelo(Guid.NewGuid(), new Guid(modelo.IDMARCA), modelo.NOME, modelo.MARCA ,modelo.IMAGEM);
            _service.post(_modelo);

            return await Task.FromResult(CreatedAtAction(nameof(GetModeloById), new { id = _modelo.ID }, _modelo));
        }

        [HttpGet("[action]")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<ModeloModel>> GetModeloById(Guid pId)
        {
            var modelo = _service.get(pId);
            if (modelo == null) return NotFound();

            var response = _mapper.Map<ModeloModel>(modelo);
            return await Task.FromResult(response);
        }

        [HttpGet("[action]")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<List<ModeloModel>>> ListModelos()
        {
            var response = _mapper.Map<List<ModeloModel>>(_service.list());
            return await Task.FromResult(response);
        }

        [HttpDelete("[action]")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> DeleteModelo(Guid pId)
        {
            _service.delete(pId);
            return await Task.FromResult(NoContent());
        }

        [HttpPut("[action]")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<ModeloModel>> UpdateModelo(ModeloModel modelo)
        {
            _service.put(_mapper.Map<Modelo>(modelo));

            return await Task.FromResult(CreatedAtAction(nameof(GetModeloById), new { id = modelo.ID }, modelo));
        }

        [HttpGet("[action]")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<List<ModeloModel>>> GetModeloByMarcaId(Guid pId)
        {
            var modelo = _service.list().Where(m => m.IDMARCA == pId).ToList();

            if (modelo == null) return NotFound();

            var response = _mapper.Map<List<ModeloModel>>(modelo);
            return await Task.FromResult(response);
        }
    }
}