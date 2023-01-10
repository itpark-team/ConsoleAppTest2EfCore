using ConsoleAppTest2EfCore.DbConnection;
using ConsoleAppTest2EfCore.DbEntities;

namespace ConsoleAppTest2EfCore.Repositories;

public class CountriesRepository
{
    private DbManager _dbManager;

    public CountriesRepository(DbManager dbManager)
    {
        _dbManager = dbManager;
    }

    public Country GetById(int id)
    {
        return _dbManager.Countries.First(country => country.Id == id);
    }

    public List<Country> GetAllCountries()
    {
        return _dbManager.Countries.ToList();
    }
}