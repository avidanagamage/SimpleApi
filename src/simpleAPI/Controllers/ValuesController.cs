using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace simpleAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value 1", "value 2" };
        }

        [HttpGet("Get/{id}")]
        public ActionResult<string> Get(int id)
        {
            return $" return {id}";
        }

    }
}