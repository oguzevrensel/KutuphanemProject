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
    public class PersonelController : ControllerBase
    {

        private readonly IPersonelService _service;

        public PersonelController(IPersonelService service)
        {
            _service = service;
        }

        // GET: api/<PersonelController>
        [HttpGet]
        public IEnumerable<Personel> Get()
        {
            return _service.GetAll();
        }

        // GET api/<PersonelController>/5
        [HttpGet("{id}")]
        public Personel Get(int id)
        {
            return _service.Get(x => x.PersonelId == id);
        }

        // POST api/<PersonelController>
        [HttpPost]
        public void Post([FromBody] Personel personel)
        {
            _service.Insert(personel);
        }

        // PUT api/<PersonelController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Personel personel)
        {
            personel.PersonelId = id;
            _service.Update(personel);
        }

        // DELETE api/<PersonelController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(new Personel { PersonelId = id });
        }
    }
}