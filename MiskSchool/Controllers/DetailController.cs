using AutoMapper;
using InterviewTask.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using MiskSchool.Infrastructure.IRepositories;
using MiskSchool.Models.Entities;

namespace InterviewTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailController : ControllerBase
    {
        private readonly IDetailRepository _repository;
        private IMapper _mapper;

        public DetailController(IDetailRepository repository, IMapper mapper)
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
        [HttpPost]
        public async Task<IActionResult> Post(ProgramDetailsDto request)
        {
            try
            {
                var req = _mapper.Map<ProgramDetails>(request);
                return Ok(await _repository.AddAsync(req));

            }
            catch (Exception ex)
            {

                throw new Exception("Internal error", ex);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Put(string id, ProgramDetailsDto request)
        {
            var req = _mapper.Map<ProgramDetails>(request);
            return Ok(await _repository.UpdateAsync(id, req));
        }
    }
}
