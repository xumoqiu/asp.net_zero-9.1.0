using System.ComponentModel.DataAnnotations;

namespace DynasysSolution.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
