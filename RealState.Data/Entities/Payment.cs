namespace RealState.Data.Entities;
public class Payment:BaseEntity
{
    public Contract Contract { get; set; }
    public int ContractId {  get; set; }
}
