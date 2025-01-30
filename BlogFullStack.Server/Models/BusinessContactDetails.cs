using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BlogFullStack.Server.Models
{
    public class BusinessContactDetails
    {

        [Key]
        public int BusinessContactID { get; set; }

        public string? BusinessContactPhoneNumber { get; set; }

        public string? BusinessContactEmail { get; set; }

        public string BusinessName { get; set; }

        public string BusinessAddress { get; set; }

    }
}
