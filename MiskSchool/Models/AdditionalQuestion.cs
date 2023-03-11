using MiskSchool.Models.Enums;

namespace MiskSchool.Models
{
    public class AdditionalQuestion
    {
        public string AboutSelf { get; set; }
        public DateTime YearOfGraduation { get; set; }
        public string Question { get; set; }
        public QuestionType QuestionType { get; set; }
    }
}
