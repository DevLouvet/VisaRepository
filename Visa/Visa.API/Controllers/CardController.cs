﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Visa.API.Controllers
{
    [Route("api/card")]
    [ApiController]
    public class CardController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id, int? expiredDate)
        {
            return "value";
        }
    }
}
