using System.ComponentModel.DataAnnotations;

namespace IdleGame1.Models
{
    public class LogMessage
    {
        [Key]
        public int MessageId { get; set; }

        public string Text { get; set; }

        public int MessageType { get; set; }
    }
}