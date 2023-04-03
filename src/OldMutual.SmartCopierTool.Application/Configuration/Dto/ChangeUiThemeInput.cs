using System.ComponentModel.DataAnnotations;

namespace OldMutual.SmartCopierTool.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
