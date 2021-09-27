using FoodApp.Application.Interface;
using FoodApp.Application.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DailyMenuController : ControllerBase
    {
        public IServingService ServingService { get; }

        public DailyMenuController(IServingService servingService)
        {
            ServingService = servingService;
        }

        [HttpPost]
        public async Task<IActionResult> GetDailyMenu([FromBody] GenderAge genderAge)
        {
            return Ok(await ServingService.GetDailyMenu(genderAge));
        }

        [HttpPost]
        [Route("Family")]
        public async Task<IActionResult> GetDailyMenu([FromBody] List<GenderAge> genderAgeList)
        {
            return Ok(await ServingService.GetFamilyDailyMenu(genderAgeList));
        }

        [HttpGet]
        [Route("AgeRange")]
        public async Task<IActionResult> GetAgeRange()
        {
            return Ok(await ServingService.GetAgeRanges());
        }

        [HttpGet]
        [Route("GenderRange")]
        public async Task<IActionResult> GetGenderRange()
        {
            return Ok(await ServingService.GetGenderRanges());
        }
    }
}