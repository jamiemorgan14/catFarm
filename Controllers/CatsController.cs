using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catFarm.Database;
using catFarm.Models;
using Microsoft.AspNetCore.Mvc;

namespace catFarm.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatsController : ControllerBase
  {

    List<Cat> CatCollection = Data.CatData;
    // GET api/Cats
    [HttpGet]
    public ActionResult<List<Cat>> Get()
    {
      return CatCollection;
    }

    // GET api/Cats/5
    [HttpGet("{id}")]
    public ActionResult<Cat> GetById(int id)
    {
      Cat TheCat = CatCollection.Find(c => c.Id == id);
      if (TheCat != null)
      {
        return TheCat;
      }
      return BadRequest("Cat does not exist");
    }

    // POST api/Cats
    [HttpPost]
    public ActionResult<List<Cat>> Post([FromBody] Cat value)
    {
      CatCollection.Add(value);
      return CatCollection;
    }

    // PUT api/Cats/5
    [HttpPut("{id}")]
    public ActionResult<Cat> Put(int id, [FromBody] Cat newCat)
    {
      Cat oldCat = CatCollection.Find(c => c.Id == id);
      if (oldCat == null) { return BadRequest("Can't find cat"); }
      CatCollection.Remove(oldCat);
      CatCollection.Add(newCat);
      return newCat;
    }

    // DELETE api/Cats/5
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      Cat oldCat = CatCollection.Find(c => c.Id == id);
      if (oldCat == null) { return BadRequest("Can't find cat"); }
      CatCollection.Remove(oldCat);
      return Ok();
    }
  }
}
