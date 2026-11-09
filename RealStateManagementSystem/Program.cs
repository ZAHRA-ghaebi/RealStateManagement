using Microsoft.EntityFrameworkCore;
using RealState.Data;
using RealStateManagementSystem;
using System.Configuration;
MyDbContextFactory.Initializa(ConfigurationManager.ConnectionStrings["RealEstateDb"].ConnectionString);
var dbContext = MyDbContextFactory.Create();
dbContext.Database.Migrate();
ApplicationConfiguration.Initialize();
bool showLogin = bool.Parse(ConfigurationManager.AppSettings["showLogin"]);
if (showLogin)
{
    Application.Run(new frmDashboard());
}
else
{
    Application.Run(new FrmLogin());
}