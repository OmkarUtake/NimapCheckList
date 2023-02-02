using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CategoryCrudMVC.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required(ErrorMessage = "CATEGORY Required")]
        public string categoryName { get; set; }

        public Item item { get; set; }

    }

    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required(ErrorMessage = "Description Required")]
        public string description { get; set; }
        [Required(ErrorMessage = "Item Required")]
        public string itemName { get; set; }
    }

    public class CategoryDbContext : DbContext
    {
        public DbSet<Category> categories { get; set; }
        public DbSet<Item> items { get; set; }
    }

    public class FieldClass
    {
        [Key]
        public int categoryId { get; set; }

        [Required(ErrorMessage = "Category Required")]
        public string categoryName { get; set; }


        public int itemId { get; set; }

        [Required(ErrorMessage = "Description Required")]
        public string itemDescription { get; set; }

        [Required(ErrorMessage = "Item Required")]
        public string itemName { get; set; }




    }

    //public class AllData
    //{
    //    public IEnumerable<Category> ctgr { get; set; }
    //    public IEnumerable<Item> itm { get; set; }
    //}


    public class AllData
    {
        public Category ctgr { get; set; }
        public Item itm { get; set; }
    }

}
