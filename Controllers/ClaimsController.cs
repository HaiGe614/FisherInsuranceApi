using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
 using FisherInsuranceApi.Models;
 [Route("api/claim")]    
 public class ClaimController : Controller    { 
 
 
     // POST api/claim        
  [HttpPost]       
  public IActionResult Post([FromBody]Claim claim)        
  {           
     return Ok();        
     } 

  [HttpGet] 
  public IActionResult GetClaims() 
  {
    return Ok(); 
    } 

  // GET api/claim/5        
  [HttpGet("{id}")]        
   public IActionResult Get(int id)        
   {
     return Ok();        
      }
   
   
   // PUT api/claim/id        
   [HttpPut("{id}")]       
   public IActionResult Put(int id, [FromBody]Claim claim)        
   {            
       return Ok();      
       }

   // DELETE api/claim/id        
   [HttpDelete("{id}")]        
   public IActionResult DeleteClaim(int id,[FromBody]Claim claim)        
   {            
       
       return Ok();    
       }
  }