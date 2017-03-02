 using Microsoft.AspNetCore.Mvc;
 using FisherInsuranceApi.Data;
 using FisherInsuranceApi.Models;
 [Route("api/quotes")]    
 public class QuotesController : Controller    {   
     // POST api/auto/quotes        
            
     
      

      [HttpGet] 
      public IActionResult GetQuotes() 
      {
        return Ok(); 
        }

      [HttpPost]
      public IActionResult Post(int id,[FromBody]Quote quote)        
      {           
         return Ok();        
         }  

         // GET api/auto/quotes/5        
        [HttpGet("{id}")]        
       public IActionResult Get(int id)        
        {
          return Ok();        
          }

           // PUT api/auto/quotes/id        
        [HttpPut("{id}")]       
         public IActionResult Put([FromBody]Quote quote)        
         {            
           return Ok();        
           }

             // DELETE api/auto/quotes/id        
        [HttpDelete("{id}")]        
        public IActionResult Delete(int id,[FromBody]Quote quote)        
        {            
           return Ok();        
          }
  }