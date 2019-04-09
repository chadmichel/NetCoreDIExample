using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIDemo.Managers;
using Microsoft.AspNetCore.Mvc;

namespace DIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IMyManager Manager { get; set; }

        public ValuesController(IMyManager manager)
        {
            Manager = manager;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Manager.Test("hi");
        }

    }
}
