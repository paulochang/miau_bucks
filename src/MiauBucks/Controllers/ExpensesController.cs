using Microsoft.AspNetCore.Mvc;
using MiauBucks.Interfaces;
using MiauBucks.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MiauBucks.Controllers
{
    [Route("api/[controller]")]
    public class ExpensesController : Controller
    {
        private readonly IExpenseRepository _expenseRepository;

        public ExpensesController(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }
        // GET: api/expenses
        [HttpGet]
        public IActionResult List()
        {
            return Ok(_expenseRepository.All);
        }

        // GET api/expenses/5
        [HttpGet("{id}", Name = "GetExpense")]
        public IActionResult Get(int id)
        {
            return Ok(_expenseRepository.Find(id));
        }

        // GET api/expenses/?user=5
        [HttpGet("{user}")]
        public IActionResult GetByUser(int user)
        {
            return Ok(_expenseRepository.FindByUser(user));
        }

        // POST api/expenses
        [HttpPost]
        public IActionResult Post([FromBody]Expense expense)
        {
            if (expense == null)
            {
                return BadRequest();
            }
            _expenseRepository.Insert(expense);
            return CreatedAtRoute("GetExpense", new { id = expense.Id }, expense);


        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Expense item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var expense = _expenseRepository.Find(id);
            if (expense == null)
            {
                return NotFound();
            }

            _expenseRepository.Update(item);
            return new NoContentResult();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var expense = _expenseRepository.Find(id);
            if (expense == null)
            {
                return NotFound();
            }

            _expenseRepository.Delete(id);
            return new NoContentResult();
        }

        [HttpGet("findByUser/{id}")]
        public IActionResult FindByUser(int id)
        {
            return Ok(_expenseRepository.Find(id));
        }
    }
}
