

using RealState.Data.Enums;

namespace RealState.Data.Entities;
public class Contract:BaseEntity
{
    public TransactionType TransactionType { get; set; }
    public int CustomerId {  get; set; }
    public Customer Customer {  get; set; }
    public int PropertyId {  get; set; }
    public Property Property { get; set; }
    public ICollection<Payment> Payments { get; set; } = [];
    public int UserId { get; set; }
    public User User { get; set; }
}
