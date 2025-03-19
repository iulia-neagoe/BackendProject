using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApp.Models;

namespace TravelApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelappCoontroller : ControllerBase
    {
        private readonly TravelappContext _context;
        public TravelappCoontroller(TravelappContext context)
        {
            _context = context;
        }

        //GET: api/TravelappItems
        [HttpGet]
        public async Task<IActionResult<IEnumerable<TravelappItem>>> GetTravelappItems()
        {
            return await _context.TravelappItems.ToListAsync();
        }
    }
}