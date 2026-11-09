namespace RealState.Data.Entities;
public class Seller:Person
{
    public ICollection<Property> Properties { get; set; } = [];
}
