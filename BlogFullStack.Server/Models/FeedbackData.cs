using System.ComponentModel.DataAnnotations;

namespace BlogFullStack.Server.Models
{
    public class FeedbackData
    {

        [Key]
        public int FeedBackID {  get; set; }

        public string Feedback {  get; set; }

        public string FeedbackEmail { get; set; }

    }
}
