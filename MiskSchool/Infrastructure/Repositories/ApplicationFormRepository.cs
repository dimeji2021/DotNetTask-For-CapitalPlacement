using MiskSchool.Infrastructure.IRepositories;
using MiskSchool.Models.Entities;

namespace InterviewTask.Infrastructure.Repository
{
    public class ApplicationFormRepository : GenericRepository<ApplicationForm>, IApplicationFormRepository
    {
        public ApplicationFormRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
