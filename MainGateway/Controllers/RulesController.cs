using MainGateway.Models;
using MainGateway.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MainGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [EnableCors("MyPolicy")]
    public class RulesController : ControllerBase
    {
        private readonly RuleService _ruleService;

        public RulesController(RuleService ruleService)
        {
            _ruleService = ruleService;
        }
        // GET: api/<RulesController>
       

        // GET api/<RulesController>/5
        [HttpGet("id")]
        public string evaluateMinBal(int id, [FromQuery] float balance)
        {
            return _ruleService.evaluateMinBal(id, balance);

        }
        [Route("/getServiceCharges")]
        // POST api/<RulesController>
        [HttpGet]
        public double getServiceCharges([FromQuery] double balance)
        {
            string value = _ruleService.getServiceCharges(balance);
            if(value==null)
            {
                return 0;
            }
            else
            {
                return Convert.ToDouble(value);
            }
          
        }
        // PUT api/<RulesController>/5
       
    }
}
