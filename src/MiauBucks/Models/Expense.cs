﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MiauBucks.Models
{
    public class Expense
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public double Value { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int UserId{get; set;}

        public Expense(double value, DateTime date, int userId)
        {
            this.Value = value;
            this.Date = date;
            this.UserId = userId;
        }
    }
}
