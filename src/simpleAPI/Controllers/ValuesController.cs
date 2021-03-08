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
            return new string[] { "val 1", "val 2" };
        }

        [HttpGet("Get/{id}")]
        public ActionResult<string> Get(int id)
        {
            return $" return {id}";
        }

    }
}