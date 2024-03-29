﻿using Clean.Core.Entities;
using Clean.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clean.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class turnsController : ControllerBase
    {
        private readonly turnsServices _turnsServices;
        public turnsController(turnsServices tS)
        {
            _turnsServices = tS;
        }
        // GET: api/<turnsController>
        [HttpGet]
        public IEnumerable<turns> Get()
        {
            return _turnsServices.GetAll();
        }

        // GET api/<turnsController>/5
        [HttpGet("{id}")]
        public turns Get(string NumRoom)
        {
            return _turnsServices.GetTurnById(NumRoom);
        }

        // POST api/<turnsController>
        [HttpPost]
        public void Post([FromBody] turns value)
        {
            _turnsServices.AddTurn(value);
        }

        // PUT api/<turnsController>/5
        [HttpPut("{id}")]
        public void Put(string NumRoom, [FromBody] turns value)
        {
            _turnsServices.UpdateTurn(value, NumRoom);
        }

        // DELETE api/<turnsController>/5
        [HttpDelete("{id}")]
        public void Delete(string NumRoom)
        {
            _turnsServices.DeleteTurn(NumRoom);
        }

    }
}

