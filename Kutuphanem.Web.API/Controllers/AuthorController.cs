using Kutuphanem.Business.Abstracts;
using Kutuphanem.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kutuphanem.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {

        private readonly IAuthorService _service;

        public AuthorController(IAuthorService service)
        {
            _service = service;
        }

        // GET: api/<AuthorController>
        [HttpGet]
        public IEnumerable<Author> Get()
        {
            return _service.GetAll();
        }

        // GET api/<AuthorController>/5
        [HttpGet("{id}")]
        public Author Get(int id)
        {
            return _service.Get(x=>x.AuthorId == id);
        }

        // POST api/<AuthorController>
        [HttpPost]
        public void Post([FromBody] Author author)
        {
            _service.Insert(author);
        }

        // PUT api/<AuthorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Author author)
        {
            author.AuthorId = id;
            _service.Update(author);
        }

        // DELETE api/<AuthorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(new Author { AuthorId = id});
        }
    }
}
