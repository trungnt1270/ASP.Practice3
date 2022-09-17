using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_TrungNT.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryID { get; set; }

        [Required]
        public string CategoryName { get; set; }

        //Navigation prop
        public virtual ICollection<Product> Products { get; set; }

    }
}