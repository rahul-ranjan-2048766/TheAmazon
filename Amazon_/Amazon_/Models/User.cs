using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon_.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public string UserImage { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
    }
}
