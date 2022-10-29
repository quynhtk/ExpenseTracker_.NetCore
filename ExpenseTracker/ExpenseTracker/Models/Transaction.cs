using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        public int CategoryID { get; set; } //foreign key 
        public Category Category { get; set; } //navigational property
        public int Amount { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string? Note { get; set; } // default: ? = null/empty
        public DateTime Date { get; set; } = DateTime.Now; // date transaction
    }
}
