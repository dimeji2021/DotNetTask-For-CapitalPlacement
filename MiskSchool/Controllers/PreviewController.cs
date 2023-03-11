using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiskSchool.Infrastructure.IRepositories;

namespace MiskSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreviewController : ControllerBase
    {
        private readonly IDetailRepository _repository;

        public PreviewController(IDetailRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var res = await _repository.GetAsync();
            if (res is not null)
            {
                return Ok(res);
            }
            return BadRequest();
        }
    }
}
