using MiskSchool.Models.Enums;

namespace MiskSchool.Models
{
    public class AdditionalInformation
    {
        public ProgramType  ProgramType { get; set; }
        public DateTime ProgramStart { get; set; }
        public DateTime ApplicationOpen { get; set; }
        public DateTime ApplicationClose { get; set; }
        public int Duration { get; set; }
        public string Location { get; set; }
        public Qualification MinQualification { get; set; }
        public int MaximumNumberOfApplication { get; set; }
    }
}
