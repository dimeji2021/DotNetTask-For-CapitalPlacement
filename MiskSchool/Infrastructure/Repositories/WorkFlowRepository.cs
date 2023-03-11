using MiskSchool.Infrastructure.IRepositories;
using MiskSchool.Models.Entities;

namespace InterviewTask.Infrastructure.Repository
{
    public class WorkFlowRepository : GenericRepository<WorkFlow>, IWorkFlowRepository
    {
        public WorkFlowRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
