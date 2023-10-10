using server.Models;
using server.Services;

// NOTE: this syntax HAS to math what is in our globals. In this case, global is sharpList NOT SharpList
namespace server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HousesController : ControllerBase
{
    private readonly HousesService _housesService;

    public HousesController(HousesService housesService)
    {
        _housesService = housesService;
    }

    [HttpGet]
    public ActionResult<List<House>> GetAllHouses()
    {
        try
        {
            List<House> houses = _housesService.GetAllHouses();
            return Ok(houses);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
