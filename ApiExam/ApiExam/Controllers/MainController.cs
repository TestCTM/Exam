using ApiExam.Interfaces;
using ApiExam.Logic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiExam.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IOperations operations;

        public MainController(IOperations operations)
        {
            this.operations = operations;
        }


        // GET: api/<MainController>
        [HttpGet("{n}")]
        public async Task<IEnumerable<string>> Get(int n)
        {
            return await operations.FizzBuzz(n);
        }

       

        
    }
}
