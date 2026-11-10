using Microsoft.EntityFrameworkCore.Internal;
using RealState.Data;
using RealState.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealState.Service;

public class UserService
{
    public void Add(
        string firstName,
        string lastName,
        string userName,
        string password,
        string phoneNumber)
    {
        var dbContextFactor = MyDbContextFactory.Create();
        var user = new User
        {
            UserName = userName,
            FirstName = firstName,
            LastName = lastName,
            Password = password,
            PhoneNumber = phoneNumber,
            RegistDate = DateTime.Now
        };
        var a = dbContextFactor.Add(user);
        dbContextFactor.SaveChanges();
    }
    public List<User> GetAll()
    {
        var dbContextFactor = MyDbContextFactory.Create();
        return dbContextFactor.Users.ToList();
    }
    public void Update(int id, string firstName)
    {
        var dbContextFactor = MyDbContextFactory.Create();
        var user = dbContextFactor.Users.First(x => x.Id == id);
        user.FirstName = firstName;
        dbContextFactor.SaveChanges();
    }
}
