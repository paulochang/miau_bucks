using MiauBucks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiauBucks.Models;

namespace MiauBucks.Services
{
    public class ExpenseRepository : IExpenseRepository

    {
        private List<Expense> _expenseList;
        public ExpenseRepository()
        {
            InitializeData();
        }

        private void InitializeData()
        {
            _expenseList = new List<Expense>();

            var expense1 = new Expense(1, 100, new DateTime(2016, 1, 1));
            var expense2 = new Expense(2, 200, new DateTime(2016, 1, 1));
            var expense3 = new Expense(3, 200, new DateTime(2016, 1, 1));

            _expenseList.Add(expense1);
            _expenseList.Add(expense2);
            _expenseList.Add(expense3);
        }

        public IEnumerable<Expense> All
        {
            get
            {
                return _expenseList;
            }
        }

        public void Delete(int id)
        {
            _expenseList.Remove(this.Find(id));
        }

        public Expense Find(int id)
        {
            return _expenseList.FirstOrDefault(item => item.Id == id);
        }

        public void Insert(Expense item)
        {
            _expenseList.Add(item);
        }

        public void Update(Expense item)
        {
            var expense = this.Find(item.Id);
            var index = _expenseList.IndexOf(item);
            _expenseList.RemoveAt(index);
            _expenseList.Insert(index, item);
        }
    }
}
