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

    [HttpPost]
    public ActionResult<House> createHouse([FromBody] House houseData)
    {
        try
        {
            House house = _housesService.CreateHouse(houseData);
            return Ok(house);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
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

    [HttpGet("{houseId}")]
    public ActionResult<House> GetHouseById(int houseId)
    {
        try
        {
            House house = _housesService.GetHouseById(houseId);
            return Ok(house);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
