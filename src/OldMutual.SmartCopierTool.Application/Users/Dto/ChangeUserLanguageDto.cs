using System.ComponentModel.DataAnnotations;

namespace OldMutual.SmartCopierTool.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}