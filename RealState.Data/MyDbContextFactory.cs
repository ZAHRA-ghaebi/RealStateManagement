
namespace RealState.Data;

public class MyDbContextFactory
{
    private static string _ConnectionString;
  
    public static void Initializa( string connectionString)
    {
        _ConnectionString = connectionString;
    }
    public static RealStateDbcontext Create()
    {
        return new RealStateDbcontext(_ConnectionString);
    }
}
