using Microsoft.AspNetCore.Mvc;
using RulesApi.Models;
using RulesApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RulesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RulesController : ControllerBase
    {
        private readonly RulesService _rulesService;

        public RulesController(RulesService rulesService) 
        {
            _rulesService = rulesService;
        }


        // GET 
        // http://localhost:5000/api/Rules/id?id=505&balance=50000
        [HttpGet("id")]
        public string evaluateMinBal(int id, [FromQuery] float balance)
        {
            return _rulesService.evaluateMinBal(id, balance);
           
        }
        // GET
        // http://localhost:5000/api/Rules?balance=450
        [HttpGet]
        public float getServiceCharges([FromQuery] float balance)
        {
            return _rulesService.getServiceCharges(balance);
        }

  
    }
}
