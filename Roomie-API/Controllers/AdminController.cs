using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Roomie_API.DTOs;
using Roomie_API.Interfaces.Services;

namespace Roomie_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _service;

        public AdminController(IAdminService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdminDTO>>> Index()
        {
            var dto = await _service.GetAllAsync();

            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        [HttpGet("{id:int}", Name = "GetUsuario")]
        public async Task<ActionResult<IEnumerable<AdminDTO>>> Index(int id)
        {
            var dto = await _service.GetByIdAsync(id);

            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] AdminDTO dto)
        {
            if (dto == null)
                return BadRequest("Dados Inválidos");

            await _service.CreateAsync(dto);

            return new CreatedAtRouteResult("GetUsuario", new { id = dto.Id }, dto);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Update(int id, [FromBody] AdminDTO dto)
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
