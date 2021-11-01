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
    public class TransactionHistoryController : ControllerBase
    {
        private  readonly TransactionMSService _service;

        public TransactionHistoryController(TransactionMSService transactionService)
        {
            _service = transactionService;
        }
        // GET: api/<TransactionHistoryController>
        [HttpGet("getTransactions/{id}")]
        public IList<TransactionHistoryDTO> Get(int id)
        {
            return _service.getTransactions(id);
        }


        // POST api/<TransactionHistoryController>
        [Route("Deposit")]
        [HttpPost]
        public string Deposit([FromBody] DepositDTO value)
        {
            return _service.DepositMoney(value);
        }

        [Route("Withdraw")]
        [HttpPost]
        public string Withdraw([FromBody] DepositDTO value)
        {
            return _service.WithdrawMoney(value);
        }

        [Route("Transfer")]
        [HttpPost]
        public StatusDTO Transfer([FromBody] TransferDTO value)
        {
            return _service.Transfer(value);
        }

    }
}
