using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiskSchool.Models.Entities
{
    public class ApplicationForm: BaseEntity
    {
        public string ImageUrl { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
        public Profile Profile { get; set; }
        public AdditionalQuestion AdditionalQuestion { get; set; }
    }
}
