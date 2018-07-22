using System.ComponentModel.DataAnnotations;

namespace GPDH.Evolution.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}