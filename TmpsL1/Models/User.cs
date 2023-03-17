using System.ComponentModel.DataAnnotations.Schema;

namespace TmpsL1.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
