using Clean.Core.Entities;
using Clean.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clean.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class clientsController : ControllerBase
    {
        private readonly clientsServices _clientsServices;
        public clientsController(clientsServices clientsServices)
        {
            _clientsServices = clientsServices;
        }
        // GET: api/<clientsController>
        [HttpGet]
        public IEnumerable<clients> Get()
        {
            return _clientsServices.GetAll();
        }

        // GET api/<clientsController>/5
        [HttpGet("{id}")]
        public clients Get(int id)
        {
            return _clientsServices.GetClientById(id);
        }

        // POST api/<clientsController>
        [HttpPost]
        public void Post([FromBody] clients value)
        {
            _clientsServices.AddClient(value);
        }

        // PUT api/<clientsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] clients value)
        {
            _clientsServices.UpdateClient(value, id);
        }

    }
}



