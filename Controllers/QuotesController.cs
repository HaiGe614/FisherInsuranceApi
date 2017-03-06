 using Microsoft.AspNetCore.Mvc;
 using FisherInsuranceApi.Data;
 using FisherInsuranceApi.Models;
 [Route("api/quotes")]    
 public class QuotesController : Controller    {
   private readonly FisherContext db;
   public QuotesController(FisherContext context)
   {
     db = context;
     }
   
    
      [HttpGet]
      public IActionResult GetQuotes()
      {
        return Ok(db.Quotes);
        }

      [HttpGet("{id}", Name = "GetQuotes")]
      public IActionResult Get(int id)
      {
        return Ok(db.Quotes.Find(id));
        }

      [HttpPost]
      public IActionResult Post([FromBody] Quote quote)
      {
        var newQuotes = db.Quotes.Add(quote);
        db.SaveChanges();
        
        return CreatedAtRoute("GetQuotes", new { id = quote.Id }, quote);
        }

         // Put api/auto/quotes/5        
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Quote quote)
        {
          var newQuotes = db.Quotes.Find(id);
          if (newQuotes == null)
          {
            return NotFound();
            }
            newQuotes = quote;
            db.SaveChanges();
            return Ok(newQuotes);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
          var Quotestodelete = db.Quotes.Find(id);
          if (Quotestodelete == null)
          {
            return NotFound();
            }
            db.Quotes.Remove(Quotestodelete);
            db.SaveChangesAsync();
            return NoContent();
            }
 }