using System;
using System.Collections.Generic;
using System.Text;

namespace RealState.Data.Entities;

public class Person:BaseEntity
{
    public long Budget { get; set; }
    public string FirstName {  get; set; }=string.Empty;
    public string LastName { get; set; }= string.Empty; 
    public string NationalCode {  get; set; }=string.Empty;
    public string PhoneNumber {  get; set; }=string.Empty;
    public string Address {  get; set; }=string.Empty;
    public string Description {  get; set; }=string.Empty;

}
