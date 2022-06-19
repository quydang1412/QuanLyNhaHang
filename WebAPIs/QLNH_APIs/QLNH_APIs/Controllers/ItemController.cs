using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNH_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _context.Item.ToList();
        }
    }
}
