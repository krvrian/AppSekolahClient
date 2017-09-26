using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSekolahClient
{
    public class login
    {
        public string token { get; set; }
        public List<dataUser> dataUser { get; set; }
    }

    public class dataUser
    {
        public string employee_id { get; set; }
        public string username { get; set; }
        public int role { get; set; }
        public string firstlogin { get; set; }
    }
}
