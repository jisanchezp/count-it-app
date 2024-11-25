using CountIt.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountIt.DAL.Models
{
    public class Transaction
    {
        [Key]
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public CurrencyEnum Currency { get; set; }
        public TransactionTypeEnum Type { get; set; } = TransactionTypeEnum.Expense;
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public string? Description { get; set; }
    }
}
