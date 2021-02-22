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
    public class ColorController : Controller
    {
        IColorService _colorservice;

        public ColorController(IColorService colorservice)
        {
            _colorservice = colorservice;
        }
        [HttpGet("getallcolor")]
        public IActionResult GetAll()
        {
            var result = _colorservice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyidcolor")]
        public IActionResult GetById(int id)
        {
            var result = _colorservice.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("addcolor")]
        public IActionResult Add(Color color)
        {
            var result = _colorservice.Add(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deletecolor")]
        public IActionResult Delete(Color color)
        {
            var result = _colorservice.Delete(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updatecolor")]
        public IActionResult Update(Color color)
        {
            var result = _colorservice.Update(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
