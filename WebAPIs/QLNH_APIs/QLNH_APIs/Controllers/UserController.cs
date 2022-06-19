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
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _context.User.ToList();
        }
    }
}
