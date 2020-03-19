using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WordFinderApi.Models
{
    public class ApiRequestModel
    {
        [Required]        
        public List<string> Dictionary{ get; set; }

        [Required]        
        public List<string> Src { get; set; }
    }
}
