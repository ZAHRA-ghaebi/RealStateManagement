namespace RealState.Data.Entities;
public class BaseEntity
{
    public int Id {  get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeleteAT {  get; set; }
}
