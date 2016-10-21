using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaudaMaster.SharedModel
{



    public class SubCategoryViewModel
    {
        public int SubCategoryID { get; set; }
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]


        public int CategoryName { get; set; }

        [Required]
        [DisplayName("SubCategory Name")]
        public string SubCategoryName { get; set; }

        [Required]
        [DisplayName("SubCategory Title")]
        public string SubCategoryDisplayName { get; set; }


        public string SubCategoryImage { get; set; }

        public List<SubCategoryViewModel> SubCategoryList { get; set; }
    }

}
