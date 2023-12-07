using citiinfo.API.Entities;

namespace citiinfo.API.Services
{
    public interface ICityInfoRepository
    {
        // IQueryable<City> GetCities();
        // Task<IEnumerable<City>> GetCitiesAsync();
        // IEnumerable<City> GetCities();
        Task<IEnumerable<City>> GetCitiesAsync();

        Task<City?> GetCityAsync(int cityId, bool includePointsOfInterest);

        Task<IEnumerable<PointOfInterest>> GetPointsOfInterestsForCityAsync(int cityId);

        Task<PointOfInterest?> GetPointOfInterestsForCityAsync(int cityId, int pointsOfInterestId);
    }
}