using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box.Models.Models
{
    public class Rack
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Rack name is Required")]
        [MaxLength(60,ErrorMessage ="There are alot characters in the field {0}  , just use max 60 chars by rack name")]
        public string RackName { get; set; }
        [Required]
        [MaxLength]
        public string? RackDescription { get; set; }
        public bool RackStatus { get; set;}
    }
}

