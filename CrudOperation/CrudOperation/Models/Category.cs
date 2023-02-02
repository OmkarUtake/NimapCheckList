using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudOperation.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string name { get; set; }

        [Required(ErrorMessage = "Field required")]
        //[Range(5,20)]
        public string description { get; set; }


        public Item myitem { get; set; }
    }

    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int itemid { get; set; }

        [Required(ErrorMessage = "required")]
        public string item { get; set; }
    }

    public class CategoryContext : DbContext
    {
        public DbSet<Item> items { get; set; }
        public DbSet<Category> categories { get; set; }
    }


    public class CategoryDto
    {
        public string name { get; set; }

        [Required]

        public string description { get; set; }


        public string myitem { get; set; }
    }
}