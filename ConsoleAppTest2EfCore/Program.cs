using ConsoleAppTest2EfCore.DbConnection;
using ConsoleAppTest2EfCore.DbEntities;
using ConsoleAppTest2EfCore.Repositories;

DbManager dbManager = new DbManager();

UsersRepository usersRepository = new UsersRepository(dbManager);
CountriesRepository countriesRepository = new CountriesRepository(dbManager);

// foreach (User user in usersRepository.GetAllUsers())
// {
//     Console.WriteLine(user);
// }

// User user = usersRepository.GetById(1);
// Console.WriteLine(user);

// Country addedCountry = countriesRepository.GetById(2);
// List<Country> countries = countriesRepository.GetAllCountries();
//
// User addedUser = new User()
// {
//     Nickname = "CCC",
//     Country = countries[2]
// };
// usersRepository.AddNew(addedUser);

// usersRepository.DeleteById(7);

User newUser = new User()
{
    Id = 6,
    Nickname = "abc",
    CountryId = 1
};

usersRepository.Update(newUser);