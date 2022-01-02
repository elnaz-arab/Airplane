using System.ComponentModel.DataAnnotations;

namespace Airplane
{
    public class User
    {
        [Key]
        public int Id_User { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Codmeli { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}