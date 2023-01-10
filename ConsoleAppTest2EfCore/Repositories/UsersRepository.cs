using ConsoleAppTest2EfCore.DbConnection;
using ConsoleAppTest2EfCore.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppTest2EfCore.Repositories;

public class UsersRepository
{
    private DbManager _dbManager;

    public UsersRepository(DbManager dbManager)
    {
        _dbManager = dbManager;
    }

    public List<User> GetAllUsers()
    {
        return _dbManager.Users
            .Include(user => user.Country)
            .ToList();
    }

    public User GetById(int id)
    {
        return _dbManager.Users
            .Include(user => user.Country)
            .First(user => user.Id == id);
    }

    public void AddNew(User user)
    {
        _dbManager.Users.Add(user);
        _dbManager.SaveChanges();
    }

    public void DeleteById(int id)
    {
        User user = _dbManager.Users.First(user => user.Id == id);
        _dbManager.Users.Remove(user);
        _dbManager.SaveChanges();
    }

    public void Update(User newUser)
    {
        User oldUser = _dbManager.Users.First(user => user.Id == newUser.Id);

        oldUser.Nickname = newUser.Nickname;
        oldUser.CountryId = newUser.CountryId;

        _dbManager.SaveChanges();
    }
}