using Appareil.BL.Implementations;
using Appareil.BL.Interfaces;
using Appareil.BL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Appareil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppareilController : ControllerBase
    {
        private readonly IAppareilBL _appareilBL;

        public AppareilController(IAppareilBL appareilBL)
        {
            _appareilBL = appareilBL;
        }


        // GET: api/<ApprareilController>
        [HttpGet("{id}")]
        public ActionResult<AppareilDTO> GetById(int id)
        {
            return Ok(_appareilBL.GetById(id));
        }

        [HttpGet]
        public ActionResult<List<AppareilDTO>> GetByAll()
        {
            return Ok(_appareilBL.GetAll());
        }

        [HttpPut]
        public ActionResult<int> Update(AppareilDTO appareilDTO)
        {
            return Ok(_appareilBL.Update(appareilDTO));
        }

        [HttpPost]
        public ActionResult<int> Create([FromBody] AppareilDTO appareilDTO)
        {
            return Ok(_appareilBL.Create(appareilDTO));                     
        }

        [HttpDelete("id")]
        public ActionResult<int> Delete(int id)
        {
            return Ok(_appareilBL.Delete(id));
        }


    }
}
