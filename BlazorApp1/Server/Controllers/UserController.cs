using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Server.DAL;
using BlazorApp1.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly BlazorappDB _context;
        public UserController(BlazorappDB context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("api/[controller]/users")]
        public IEnumerable<salam> Get()
        {

            return _context.users.ToList();

        }

        [HttpPost]
        [Route("api/[controller]/adduser")]
        public void adduserindex(salam user)
        {
            if (user != null)
            {
                _context.users.Add(user);
                _context.SaveChanges();
            }
        }


        [HttpGet]
        [Route("api/[controller]/detail/{id}")]
        public salam GetUserDetail(int id)
        {
            salam tester = _context.users.Find(id);
            if (tester != null)
            {
                return tester;
            }
            salam incorrect = new salam();
            incorrect.Id = 0;
            incorrect.Name = null;
            incorrect.Surname = null;
                
            return incorrect;
        }

        [HttpPut]
        [Route("api/[controller]/Edit")]
        public void Edituser(salam user)
        {
            if (user != null)
            {
                _context.Entry(user).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        [HttpPost]
        [Route("api/[controller]/Delete")]
        public void Deleteuser(salam user)
        {
            if (user != null)
            {
                _context.users.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}
