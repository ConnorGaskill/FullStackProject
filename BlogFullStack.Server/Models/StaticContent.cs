using System.ComponentModel.DataAnnotations;

namespace BlogFullStack.Server.Models
{
    public class StaticContent
    {
        [Key]
        public int StaticContentID {  get; set; }

        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public String Author { get; set; }

        //Ambiguous, fix later
        public string Content { get; set; }
    }
}
