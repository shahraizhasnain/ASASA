using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace SaudaMaster.SharedModel
{
    public class BrandViewModel
    {
        public int BrandID { get; set; }

        [Required]
        [DisplayName("Brand Name")]
        public string BrandName { get; set; }

        [Required]
        [DisplayName("Brand Title")]
        public string BrandTitle { get; set; }

        [Required]
        [DisplayName("Brand Description")]
        public string BrandDescription { get; set; }

        
        
        public string BrandImage { get; set; }

        public List<BrandViewModel> BrandList { get; set; }
    }
}
