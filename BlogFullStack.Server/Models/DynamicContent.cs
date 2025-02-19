using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace BlogFullStack.Server.Models
{
    [Authorize]
    public class DynamicContent
    {
        [Key]
        public int DynamicContentID { get; set; }

        public string Name { get; set; }

        public string Body { get; set; }

        public string Author {  get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastModifiedDate { get; set; }

        //Ambiguous, fix later
        public string Content { get; set; }
    }
}
