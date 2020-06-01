using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMASTConnect.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMASTConnect.CMS.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormsController : ControllerBase
    {
        [HttpGet]
        public Post Get(int formId)
        {
            return new Post();
        }

        [HttpPost("/saveFormData")]
        public ActionResult ActionResult(Form post)
        {
            return Ok();
        }
    }
}
