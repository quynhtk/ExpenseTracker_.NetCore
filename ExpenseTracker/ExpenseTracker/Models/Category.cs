using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string Icon { get; set; } = ""; //category icon as an empty string
        [Column(TypeName = "nvarchar(20)")]
        public string Type { get; set; } = "Expense"; //expense or income -> transaction usually expense -> default: expense
        
        //show inside the first column - nothing to do with the structure
        //dont use to assigning the value 
        [NotMapped]      
        public string? TitleWithIcon
        {
            get
            {
                return this.Icon + " " + this.Title;
            }
        }
    }
}
