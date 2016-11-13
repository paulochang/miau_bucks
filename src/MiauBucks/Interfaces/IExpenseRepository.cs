using MiauBucks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiauBucks.Interfaces
{
    public interface IExpenseRepository
    {
        IEnumerable<Expense> All { get; }
        Expense Find(int id);
        void Insert(Expense item);
        void Update(Expense item);
        void Delete(int id);
    }
}
