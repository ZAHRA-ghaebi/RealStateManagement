
namespace RealState.Data.Entities;

public class User : BaseEntity
{

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string PhoneNumber {  get; set; } = string.Empty;
    public string UserName {  get; set; }= string.Empty;
    public string Password {  get; set; }= string.Empty;
    public DateTime RegistDate {  get; set; }= DateTime.Now;
    public ICollection<Contract> Contracts { get; set; } = [];
}
