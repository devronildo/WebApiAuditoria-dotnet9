using ApiAuditoria.Data;
using ApiAuditoria.Services.Auditoria;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuditoria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuditoriaController : ControllerBase
    {
        private readonly IAuditoriaInterface _auditoriaInterface;

        public AuditoriaController(IAuditoriaInterface auditoriaInterface)
        {
            _auditoriaInterface = auditoriaInterface;
        }

        [HttpGet("Auditoria")]
        public async Task<IActionResult> BuscarAlditorias()
        {
            var auditorias = await _auditoriaInterface.BuscarAuditorias();
            return Ok(auditorias);
        }
    }
}
