using MiskSchool.Models;
using MiskSchool.Models.Enums;

namespace InterviewTask.Models.Dtos
{
    public class ProgramDetailsDto
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
