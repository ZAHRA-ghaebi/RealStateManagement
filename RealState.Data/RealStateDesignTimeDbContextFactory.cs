using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealState.Data;

public class RealStateDesignTimeDbContextFactory : IDesignTimeDbContextFactory<RealStateDbcontext>
{
    public RealStateDbcontext CreateDbContext(string[] args)
    {
        return new RealStateDbcontext("Server=(local);Database=RealEstateDb;Integrated Security=True;TrustServerCertificate=True;");
    }
}
