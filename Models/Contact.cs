using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ContactManager.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public ContactStatus Status { get; set; }
        public string OwnerID { get; set; }
        public IdentityUser Owner { get; set; }
    }

    public enum ContactStatus
    {
        Submitted,
        Approved,
        Rejected
    }
}