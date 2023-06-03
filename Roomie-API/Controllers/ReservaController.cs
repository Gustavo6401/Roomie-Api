using Microsoft.AspNetCore.Mvc;
using Roomie_API.DTOs;
using Roomie_API.Interfaces.Services;

namespace Roomie_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly IReservaService _service;

        public ReservaController(IReservaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReservaDTO>>> Index()
        {
            var dto = await _service.GetAllAsync();

            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        [HttpGet("{id:int}", Name = "GetReserva")]
        public async Task<ActionResult<IEnumerable<ReservaDTO>>> Index(int id)
        {
            var dto = await _service.GetByIdAsync(id);

            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ReservaDTO dto)
        {
            if (dto == null)
                return BadRequest("Dados Inválidos");

            await _service.CreateAsync(dto);

            return new CreatedAtRouteResult("GetReserva", new { id = dto.Id }, dto);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Update(int id, [FromBody] ReservaDTO dto)
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
