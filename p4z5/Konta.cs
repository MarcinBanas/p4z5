using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4z5
{
    class Konta
    {
        public Konta(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public String UserName { get; set; }
        public String Password { get; set; }
    }

    
}
