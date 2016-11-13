using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MiauBucks.Models
{
    public class Expense
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public double Value { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public Expense(int id, double value, DateTime date)
        {
            this.Id = id;
            this.Value = value;
            this.Date = date;
        }
    }
}
