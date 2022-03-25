using AggregatorApi.Models;
using AggregatorApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AggregatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public HomeController(CustomerService customerService) =>
            _customerService = customerService;

        [HttpGet]
        public async Task<List<Customer>> Get() =>
            await _customerService.GetAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Customer>> Get(string id)
        {
            var Customer = await _customerService.GetAsync(id);

            if (Customer is null)
            {
                return NotFound();
            }

            return Customer;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Customer newBook)
        {
            await _customerService.CreateAsync(newBook);

            return CreatedAtAction(nameof(Get), new { id = newBook.Id }, newBook);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Customer updatedBook)
        {
            var Customer = await _customerService.GetAsync(id);

            if (Customer is null)
            {
                return NotFound();
            }

            updatedBook.Id = Customer.Id;

            await _customerService.UpdateAsync(id, updatedBook);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var Customer = await _customerService.GetAsync(id);

            if (Customer is null)
            {
                return NotFound();
            }
            else 
            {
            await _customerService.RemoveAsync(Customer.Id);
            }

            return NoContent();
        }
    }
}
