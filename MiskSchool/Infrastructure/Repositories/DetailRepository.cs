using MiskSchool.Infrastructure.IRepositories;
using MiskSchool.Models.Entities;

namespace InterviewTask.Infrastructure.Repository
{
    public class DetailRepository : GenericRepository<ProgramDetails>, IDetailRepository
    {
        public DetailRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
