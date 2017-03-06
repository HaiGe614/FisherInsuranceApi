using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FisherInsuranceApi.Models;
using FisherInsuranceApi.Data;

 
 [Route("api/claim")]
 
 public class ClaimController : Controller    {
   
   private readonly FisherContext db;
   public ClaimController(FisherContext context)
 {
   db = context;
   }    
    
 
 
  [HttpPost]
  public IActionResult Post([FromBody] Claim claim)
  {
    var newClaim = db.Claims.Add(claim);
    db.SaveChanges();
  
    return CreatedAtRoute("GetClaim", new { id = claim.Id }, claim);
    }
     

  [HttpGet]
  public IActionResult GetClaims() 
  {
    return Ok(db.Claims);
    }

  [HttpGet("{id}", Name = "GetClaim")]
  public IActionResult Get(int id)
  {
    return Ok(db.Claims.Find(id));
    }


   // PUT api/claim/id        
   [HttpPut("{id}")]
   public IActionResult Put(int id, [FromBody] Claim claim)
   {
     var newClaim = db.Claims.Find(id);
     if (newClaim == null)
     {
       return NotFound();
       }
       newClaim = claim;
       db.SaveChanges();
       return Ok(newClaim);
   }

   // DELETE api/claim/id        
   [HttpDelete("{id}")]
   public IActionResult Delete(int id)
   {
     var claimToDelete = db.Claims.Find(id);
     if (claimToDelete == null)
     {
       return NotFound();
       }
       db.Claims.Remove(claimToDelete);
       db.SaveChangesAsync();
       return NoContent();
   }
       }