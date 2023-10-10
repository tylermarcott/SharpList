using server.Models;
using server.Repositories;

namespace server.Services;

public class HousesService
{
    private readonly HousesRepository _repo;

    public HousesService(HousesRepository repo)
    {
        _repo = repo;
    }

    internal House CreateHouse(House houseData)
    {
        House house = _repo.CreateHouse(houseData);
        return house;
    }

    internal List<House> GetAllHouses()
    {
        List<House> houses = _repo.GetAllHouses();
        return houses;
    }

    internal House GetHouseById(int houseId)
    {
        House house = _repo.GetHouseById(houseId);
        if (house == null) throw new Exception($"no house with the following id: {houseId}");
        return house;
    }

    internal string DeleteHouse(int houseId)
    {
        House house = this.GetHouseById(houseId);
        _repo.DeleteHouse(houseId);
        return $"{house.Bedrooms} bedroom, {house.Bathrooms} bathroom house was removed from the database.";
    }
}
