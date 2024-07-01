using AutoMapper;
using Clean.Core.DTOs;
using Clean.Api.Model;
using Clean.Core;
using Clean.Core.Entities;
using Clean.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clean.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class turnsController : ControllerBase
    {
        private readonly turnsServices _turnsServices;
        private readonly IMapper _mapper;
        public turnsController(turnsServices tS,IActionResultTypeMapper mapper)
        {
            _turnsServices = tS;
            _mapper = mapper;
        }
        // GET: api/<turnsController>
        [HttpGet]
        public ActionResult<turns> Get()
        {
            var list = _turnsServices.GetAll();
            var listDto = _mapper.Map<IEnumerable<turnsDTO>>(list);

            return Ok(listDto);
        }

        // GET api/<turnsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string NumRoom)
        {

            var resOrd = _turnsServices.GetTurnById(NumRoom);
            var turDto = _mapper.Map<turnsDTO>(resOrd);

            return Ok(turDto);
        }

        // POST api/<turnsController>
        [HttpPost]
        public void Post([FromBody] turnsPostModel value)
        {
            var newTurn = new turns { NumRoom = value.NumRoom, NumTurn = value.NumTurn, IsAvailableTurn = value.IsAvailableTurn, DateTimeTurn = value.DateTimeTurn };
            _turnsServices.AddTurnAsync(newTurn);
        }

        // PUT api/<turnsController>/5
        [HttpPut("{id}")]
        public void Put(string NumRoom, [FromBody] turns value)
        {
            _turnsServices.UpdateTurnAsync(value, NumRoom);
        }

    }
}

