﻿using citiinfo.API.Models;
using citiinfo.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace citiinfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        // private readonly CitiesDataStore citiesDataStore;
        private readonly ICityInfoRepository cityInfoRepository;

        public CitiesController(ICityInfoRepository cityInfoRepository)
        {
            this.cityInfoRepository = cityInfoRepository ?? throw new ArgumentNullException(nameof(cityInfoRepository));
            // this.citiesDataStore = citiesDataStore ?? throw new ArgumentNullException(nameof(citiesDataStore));
        }

        // public JsonResult GetCities()
        // {
        //     return new JsonResult(new [] {
        //         new { id = 1, Name = "New York City" },
        //         new { id = 2, Name = "Antwerp" },
        //         new { id = 3, Name = "Paris" }
        //     });
        // }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CityWithoutPointsOfInterestDto>>> GetCities()
        {
            var cityEntities = await this.cityInfoRepository.GetCitiesAsync();

            var results = new List<CityWithoutPointsOfInterestDto>();
            foreach (var cityEntity in cityEntities)
            {
                results.Add(
                    new CityWithoutPointsOfInterestDto{
                        Id = cityEntity.Id,
                        Description = cityEntity.Description, 
                        Name = cityEntity.Name
                    }
                );
                
            }
            return Ok(results);
            // var temp = new JsonResult(this.citiesDataStore.Cities);
            // temp.StatusCode = 200;
            // return new JsonResult(this.citiesDataStore.Cities);
            // return Ok(this.citiesDataStore.Cities);
        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            // var cityToReturn = this.citiesDataStore.Cities.FirstOrDefault(c => c.Id == id);
            // if (cityToReturn == null)
            // {
            //     return NotFound();
            // }
            // return Ok(cityToReturn);
            // return new JsonResult(this.citiesDataStore.Cities.FirstOrDefault(c => c.Id == id));
            return Ok();
        }
    }
}



