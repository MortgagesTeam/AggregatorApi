using AggregatorApi.Models;
using AggregatorApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AggregatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        private readonly ContactService _contactService;
        public ContactController(ContactService contactService)=>
            _contactService = contactService;


        [HttpGet]
        public async Task<List<Contact>> Get() =>
           await _contactService.GetAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Contact>> Get(string id)
        {
            var Contact = await _contactService.GetAsync(id);

            if (Contact is null)
            {
                return NotFound();
            }

            return Contact;
        }
        [HttpPost]
        public async Task<IActionResult> Post(Contact newContact)
        {
            await _contactService.CreateAsync(newContact);

            return CreatedAtAction(nameof(Get), new { id = newContact.Id }, newContact);
        }
    }
}
