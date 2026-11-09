using RealState.Data.Enums;

namespace RealState.Data.Entities;

public class Customer : Person
{ 
    public DateTime RegistrationDate { get; set; }
    public ICollection<Contract> Contracts { get; set; } = [];
    public PropertyArea propertyArea { get; set; }
    public PropertyType propertyType { get; set; }
    public TransactionType transactionType { get; set; }
}
