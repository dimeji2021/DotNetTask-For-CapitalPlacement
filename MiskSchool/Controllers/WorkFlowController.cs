using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MiskSchool.Infrastructure.IRepositories;
using MiskSchool.Models.Dtos;
using MiskSchool.Models.Entities;

namespace MiskSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkFlowController : ControllerBase
    {
        private readonly IWorkFlowRepository _repository;
        private IMapper _mapper;

        public WorkFlowController(IWorkFlowRepository repository, IMapper mapper)
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
        public async Task<IActionResult> Put(string id, WorkFlowDto request)
        {
            var req = _mapper.Map<WorkFlow>(request);
            return Ok(await _repository.UpdateAsync(id, req));
        }
    }
}
