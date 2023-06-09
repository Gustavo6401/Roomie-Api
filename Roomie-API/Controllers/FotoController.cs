﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Roomie_API.DTOs;
using Roomie_API.Interfaces.Services;

namespace Roomie_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FotoController : ControllerBase
    {
        private readonly IFotoService _service;

        public FotoController(IFotoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FotoDTO>>> Index()
        {
            var dto = await _service.GetAllAsync();

            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        [HttpGet("{id:int}", Name = "GetFoto")]
        public async Task<ActionResult<IEnumerable<FotoDTO>>> Index(int id)
        {
            var dto = await _service.GetByIdAsync(id);

            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] FotoDTO dto)
        {
            if (dto == null)
                return BadRequest("Dados Inválidos");

            await _service.CreateAsync(dto);

            return new CreatedAtRouteResult("GetFoto", new { id = dto.Id }, dto);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Update(int id, [FromBody] FotoDTO dto)
        {
            if (id == dto.Id)
                return BadRequest();

            if (dto == null)
                return BadRequest("Dados Inválidos");

            await _service.UpdateAsync(dto);

            return Ok(dto);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);

            return Ok("Dados Deletados com Sucesso!");
        }
    }
}
