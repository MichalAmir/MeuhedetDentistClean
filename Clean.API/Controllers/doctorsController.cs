using Clean.Core.Entities;
using Clean.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clean.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class doctorsController : ControllerBase
    {
        private readonly doctorsServices _doctorsServices;
        public doctorsController(doctorsServices doctorsServices)
        {
            _doctorsServices = doctorsServices;
        }
        // GET: api/<doctorsController>
        [HttpGet]
        public IEnumerable<doctors> Get()
        {
            return _doctorsServices.GetAll();
        }

        // GET api/<doctorsController>/5
        [HttpGet("{id}")]
        public doctors Get(int id)
        {
            return _doctorsServices.GetDoctorById(id);
        }

        // POST api/<doctorsController>
        [HttpPost]
        public void Post([FromBody] doctors value)
        {
            _doctorsServices.AddDoctor(value);
        }

        // PUT api/<doctorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] doctors value)
        {
            _doctorsServices.UpdateDoctor(value, id);
        }

    }
}

