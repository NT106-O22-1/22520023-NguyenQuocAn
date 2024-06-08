using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Bai04
{
    internal class signupUserData
    {
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int sex { get; set; }
        public string birthday { get; set; }
        public string language { get; set; }
        public string phone { get; set; }
        public signupUserData()
        {
            this.username = string.Empty;
            this.email = string.Empty;
            this.password = string.Empty;
            this.first_name = string.Empty;
            this.last_name = string.Empty;
            this.sex = 1;
            this.birthday = string.Empty;
            this.language = string.Empty;
            this.phone = string.Empty;
        }
    }
}
