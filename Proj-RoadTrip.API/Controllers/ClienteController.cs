using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proj_RoadTrip.API.Data;
using Proj_RoadTrip.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj_RoadTrip.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly DataContext context;

        public ClienteController(DataContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return context.Clientes;
        }
    }
}
