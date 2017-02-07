using Microsoft.AspNetCore.Mvc;
 [Route("api/claim")]    
 public class ClaimController : Controller    {   
     // POST api/claim        
     [HttpPost]       
      public IActionResult Post([FromBody]string value)        
      {           
         return Created("", value);        
         }  

         // GET api/claim/5        
         [HttpGet("{id}")]        
         public IActionResult Get(int id)        
         {
           return Ok("The id is: " + id);        
           }
           // PUT api/claim/id        
           [HttpPut("{id}")]       
            public IActionResult Put(int id, [FromBody]string value)        
            {            
              return NoContent();        
              }
              // DELETE api/claim/id        
              [HttpDelete("{id}")]        
              public IActionResult Delete(int id)        
              {            
                return Delete(id);        
                }
  }