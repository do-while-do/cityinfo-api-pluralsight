using citiinfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace citiinfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        // public JsonResult GetCities()
        // {
        //     return new JsonResult(new [] {
        //         new { id = 1, Name = "New York City" },
        //         new { id = 2, Name = "Antwerp" },
        //         new { id = 3, Name = "Paris" }
        //     });
        // }

        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {

            // var temp = new JsonResult(CitiesDataStore.Current.Cities);
            // temp.StatusCode = 200;
            // return new JsonResult(CitiesDataStore.Current.Cities);
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);
            // return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));
        }
    }
}



