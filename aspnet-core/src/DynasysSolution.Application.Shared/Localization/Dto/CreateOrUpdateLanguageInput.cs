using System.ComponentModel.DataAnnotations;

namespace DynasysSolution.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}