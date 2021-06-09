using Domain.Entities.Attributes;
using Domain.Entities.IdealCrm;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Domain.Entities.Users
{
    [Auditable]
    public class UserAddress
    {
        public int Id { get; set; }
        public string State { get; private set; }
        public string City { get;private set; }
        public string ZipCode { get;private set; }
        public string PostalAddress { get;private set; }
        public string UserId { get; private set; }
        public string ReciverName  { get;private set; }
        
        public UserAddress(string state,string city,string zipCode,string postalAddress,string reciverName ){
            State=state;
            this.City=city;
            ZipCode=zipCode;
            PostalAddress=postalAddress;
            ReciverName=reciverName;
        }
    }
    
}