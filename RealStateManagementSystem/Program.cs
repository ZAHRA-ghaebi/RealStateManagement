using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealState.Data;
using RealStateManagementSystem;
using System.Configuration;
MyDbContextFactory.Initializa(ConfigurationManager.ConnectionStrings["RealEstateDb"].ConnectionString);
var dbContext = MyDbContextFactory.Create();
dbContext.Database.Migrate();
ApplicationConfiguration.Initialize();
bool showLogin = RealStateManagementSystem.Properties.Settings.Default.ShowLogin;
if (showLogin)
{

    Application.Run(new frmDashboard());
}
else
{
    Application.Run(new FrmLogin());
}


