using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnignCenter.infraestructura;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorialController : ControllerBase

    {

      private iTutorialInfraestructure _tutorialInfraestructure;

      public TutorialController(iTutorialInfraestructure tutorialInfraestructure)
      {
        _tutorialInfraestructure = tutorialInfraestructure;
      }


        // GET: api/Tutorial
        [HttpGet]
        public List<string> Get()
        {
           // TutorialOracleInfraestructure tutorialOracleInfraestructure = new TutorialOracleInfraestructure();
           // return tutorialOracleInfraestructure.GetAll();

           //TutorialSQLInfraestructure tutorialSQLInfraestructure = new TutorialSQLInfraestructure();
           //return tutorialSQLInfraestructure.GetAll();

            return  _tutorialInfraestructure.GetAll();
        }

        // GET: api/Tutorial/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tutorial
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Tutorial/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Tutorial/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
