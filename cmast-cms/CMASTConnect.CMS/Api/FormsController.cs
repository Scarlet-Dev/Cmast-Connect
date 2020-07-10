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
        public ActionResult Get(int formId)
        {
            return Ok();
        }

        [HttpPost("/saveFormData")]
        public ActionResult ActionResult(Form post)
        {
            return Ok();
        }
    }
}
