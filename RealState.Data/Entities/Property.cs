using RealState.Data.Enums;

namespace RealState.Data.Entities;
public class Property:BaseEntity
{
    public string Title {  get; set; }=string.Empty;
    public string Address {  get; set; }=string.Empty;
    public float AreaSize {  get; set; }
    public int RoomCount {  get; set; }
    public int Floor {  get; set; }
    public long Price {  get; set; }
    public string Description {  get; set; }= string.Empty;
    public Seller Seller { get; set; } 
    public int SellerId {  get; set; }
    public ICollection<Contract> Contracts { get; set; } = [];
    public PropertyArea Area { get; set; }  
    public PropertyType Type { get; set; }
    public PropertyStatus Status { get; set; }  
    
}
