using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please add a name."),MinLength(8)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please add a description."),MinLength(8)]
        public string Description { get; set; } = string.Empty;
    }
}
