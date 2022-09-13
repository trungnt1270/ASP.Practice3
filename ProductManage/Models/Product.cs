using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductManage.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int ProductID { get; set; }


        [StringLength(32, MinimumLength = 3, ErrorMessage = "Use 3-32 characters")]
        public string Name { get; set; }


        [DataType(DataType.Currency)]
        public double Price { get; set; }


        [DataType(DataType.Custom)]
        public int Quantity { get; set; }


        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        //FK
        public int CategoryID { get; set; }

        //Navigation prop
        public virtual ICollection<Category> Categories { get; set; }

    }
}