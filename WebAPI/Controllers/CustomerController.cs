using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        ICustomerService _custormerService;

        public CustomerController(ICustomerService custormerService)
        {
            _custormerService = custormerService;
        }
        [HttpGet("customergetall")]
        public IActionResult GetAll()
        {
            var result = _custormerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("customergetbyid")]
        public IActionResult GetById(int id)
        {
            var result = _custormerService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("customeradd")]
        public IActionResult Add(Customer customer)
        {
            var result = _custormerService.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("customerdelete")]
        public IActionResult Delete(Customer customer)
        {
            var result = _custormerService.Delete(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("customerupdate")]
        public IActionResult Update(Customer customer)
        {
            var result = _custormerService.Udate(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
