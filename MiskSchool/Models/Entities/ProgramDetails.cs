using MiskSchool.Models.Enums;

namespace MiskSchool.Models.Entities
{
    public class ProgramDetails : BaseEntity
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public Skill KeySkill { get; set; }
        public string Benefit { get; set; }
        public string ApplicationCriteria { get; set; }
        public AdditionalInformation AdditionalInformation { get; set; }

    }
}
