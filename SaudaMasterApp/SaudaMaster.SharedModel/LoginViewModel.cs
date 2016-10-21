using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SaudaMaster.SharedModel
{
    public class LoginViewModel
    {

        public int StoreID { get; set; }
        [Required]
        public string StoreUsername { get; set; }
        [Required]
        public string StorePassword { get; set; }
    }
}
