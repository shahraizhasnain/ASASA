using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel;
using System.Web.Mvc;


namespace SaudaMaster.SharedModel
{
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }
        public int StoreID { get; set; }
        [ForeignKey("StoreID")]



        [Required]
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }

        [Required]
        [DisplayName("Category Title")]
        public string CategoryDisplayName { get; set; }

     
        public string CategoryImage { get; set; }
     public List<CategoryViewModel> CategoryList { get; set; }
    }
    
}
