using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithModel.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "Your Name: ")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Dojo Location: ")]
        public string Location { get; set; }
        [Required]
        [Display(Name = "Favorite Language: ")]
        public string Language { get; set; }
        [MinLength(20)]
        [Display(Name = "Comment (Optional): ")]
        public string Comment { get; set; }

        public Survey()
        {
            
        }
        public Survey(string name, string location, string language, string comment)
        {
            Name = name;
            Location = location;
            Language = language;
            Comment = comment;
        }
    }
}