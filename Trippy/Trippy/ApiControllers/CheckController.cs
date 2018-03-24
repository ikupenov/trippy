using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Trippy.ApiControllers
{
    [Produces("application/json")]
    [Route("api/Check")]
    public class CheckController : Controller
    {
    }
}