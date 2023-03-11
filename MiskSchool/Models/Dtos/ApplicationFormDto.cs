namespace MiskSchool.Models.Dtos
{
    public class ApplicationFormDto
    {
        public string ImageUrl { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
        public Profile Profile { get; set; }
        public AdditionalQuestion AdditionalQuestion { get; set; }
    }
}
