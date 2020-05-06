using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Enkonos.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace Enkonos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VolumeController : ControllerBase
    {
        public string Test()
        {
            var manager = new VolumeManager();

            return string.Empty;
        }
    }

}