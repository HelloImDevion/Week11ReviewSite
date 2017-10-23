using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Week11ReviewSites.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [DisplayName("Publish Date")]
        public DateTime PublishDate { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        [DisplayName("Rating out of 10")]
        public int Rating_out_of { get; set; }

        [ForeignKey("Category")]
        [DisplayName("Item")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}