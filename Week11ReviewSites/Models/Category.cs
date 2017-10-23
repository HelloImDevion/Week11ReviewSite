using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week11ReviewSites.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Name of Item")]
        public string Name_of_Item { get; set; }
        [DisplayName("Item Release Date")]
        public DateTime Item_Release_Date { get; set; }
        [DisplayName("Item Details")]
        public string Item_Details { get; set; }
    }
}