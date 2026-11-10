using RealState.Data;
using RealState.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealState.Service;

public class UserLogin
{
    public User FindUser(string userName, string password)
    {
        var dbContextFactor = MyDbContextFactory.Create();
        var result = dbContextFactor.Users
            .FirstOrDefault(x => x.UserName == userName && x.Password == password);
        return result;

    }
}
