using Microsoft.AspNetCore.Mvc;
using Restaurant_API.Models;


namespace Restaurant_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
     

       [HttpGet("All")]
        public IActionResult GetMenu()
        {
           
            var allMenu = new List<Menu>()
            {
                new Data.Models.Menu()
                {
                    Id = 1,
                    Name = "Pica Margarita",
                    Price= 500 ,
                    Description = "Djath kackavall",

                },
                new Data.Models.Menu()
                {
                  Id = 2,
                Name = "Spageti me fruta deti",
                Price = 1000,
                Description = "Spageti,fruta deti mix"
                }
             
            };

            return Ok(allMenu);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetMEnuById(int id)
        {
            var newMenu = new Data.Models.Menu()
            {
                Id = 1,
                Name = "Pica Margarita",
                Price = 500,
                Description = "Djath kackavall",
            };

            return Ok(newMenu);
        }


        [HttpPost]
        public IActionResult AddNewMenu([FromBody] Dto.PostMenuDto payload)
        {
            return Ok(payload);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateMenu([FromBody] Dto.PutMenuDto payload, int id)
        {
            return Ok(payload);
        }


        [HttpDelete("DeleteById/{id}")]
        public IActionResult DeleteMenu(int id)
        {
            return Ok();
        }

    }


}

