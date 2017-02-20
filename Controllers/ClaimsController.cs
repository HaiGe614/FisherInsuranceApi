using Microsoft.AspNetCore.Mvc;
 using FisherInsuranceApi.Data;
 using FisherInsuranceApi.Models;
 [Route("api/claim")]    
 public class ClaimController : Controller    { 
 private IMemoryStore db; 
 public ClaimController(IMemoryStore repo) 
 {
    db = repo; 
    }  
     // POST api/claim        
  [HttpPost]       
  public IActionResult Post([FromBody]Claim claim)        
  {           
     return Ok(db.CreateClaim(claim));        
     } 

  [HttpGet] 
  public IActionResult GetClaims() 
  {
    return Ok(db.RetrieveAllClaims); 
    } 

  // GET api/claim/5        
  [HttpGet("{id}")]        
   public IActionResult Get(int id)        
   {
     return Ok(db.RetrieveClaim(id));        
      }
   
   
   // PUT api/claim/id        
   [HttpPut("{id}")]       
   public IActionResult Put(int id, [FromBody]Claim claim)        
   {            
       return Ok(db.UpdateClaim(claim));      
       }

   // DELETE api/claim/id        
   [HttpDelete("{id}")]        
   public IActionResult DeleteClaim(int id,[FromBody]Claim claim)        
   {            
       db. DeleteClaim(id);
       return Ok();    
       }
  }