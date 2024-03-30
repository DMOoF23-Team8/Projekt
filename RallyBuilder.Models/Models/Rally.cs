using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RallyBuilder.Models
{
    public class Rally
    {
        [Key]
        public int RallyId { get; set; }

        [DisplayName("Rally name")]
        public string RallyName { get; set; }
    }
}
