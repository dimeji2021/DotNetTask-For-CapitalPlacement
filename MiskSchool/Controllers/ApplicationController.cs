using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MiskSchool.Infrastructure.IRepositories;
using MiskSchool.Models.Dtos;
using MiskSchool.Models.Entities;

namespace MiskSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationFormRepository _repository;
        private IMapper _mapper;

        public ApplicationController(IApplicationFormRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
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
        [HttpPut]
        public async Task<IActionResult> Put(string id, ApplicationFormDto request)
        {
            var form = await _repository.GetAsync(id);
            if (form is null)
            {
                return BadRequest();
            }
            var req = _mapper.Map<ApplicationForm>(request);
            req.Id = id;
            return Ok(await _repository.UpdateAsync(id, req));
        }
    }
}
