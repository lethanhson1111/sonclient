using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R4CloThes.Client.Pages
{
    public partial class DangKy
    {
        public string email;
        public string password;
        public string res;
        public void Regis()
        {
            res = email + ", " + password; 
        }
    }
}
