using MiskSchool.Models.Enums;

namespace MiskSchool.Models.Entities
{
    public class WorkFlow : BaseEntity
    {
        public Stage Stage { get; set; }
        public bool ShowStages { get; set; }
    }
}
