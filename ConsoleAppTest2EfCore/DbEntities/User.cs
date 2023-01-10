using System;
using System.Collections.Generic;

namespace ConsoleAppTest2EfCore.DbEntities;

public partial class User
{
    public int Id { get; set; }

    public string Nickname { get; set; }

    public int CountryId { get; set; }

    public virtual Country Country { get; set; }

    public override string ToString()
    {
        return $"#{Id} {Nickname} from {Country.Name}";
    }
}