using Microsoft.AspNetCore.Mvc;
using SS.Alteration.Application.Repositories;
using SS.Alteration.Domain.Entities;
using SS.Alteration.Domain.Enums;

namespace SS.Alteration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlterationFormsController : ControllerBase
    {
        private readonly IAlterationFormReadRepository _alterationFormReadRepository;
        private readonly IAlterationFormWriteRepository _alterationFormWriteRepository;

        public AlterationFormsController(IAlterationFormReadRepository alterationFormReadRepository, IAlterationFormWriteRepository alterationFormWriteRepository)
        {
            _alterationFormReadRepository = alterationFormReadRepository;
            _alterationFormWriteRepository = alterationFormWriteRepository;
        }

        // GET: api/<AlterationFormsController>
        [HttpGet]
        public async Task<string> Get()
        {
            //return  _alterationFormReadRepository.GetAll();
            var entity = new AlterationForm
            {
                SuitId = Guid.NewGuid(),
                Amount = 100,
                AlterationStatusId = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsPaid = false
            };

            await _alterationFormWriteRepository.InsertAsync(entity);
            var result = await _alterationFormWriteRepository.SaveAsync();
            return "";
        }

        // GET api/<AlterationFormsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AlterationFormsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AlterationFormsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlterationFormsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
