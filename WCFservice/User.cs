using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WCFservice
{
    [DataContract]
    public class User
    {
        private int userId;
        private string name;
        private string password;
        private string email;
        private string phone;

        [DataMember]
        public int UserId { get { return userId; } set { userId = value; } }
        [DataMember]
        public string Name { get { return name; } set { name = value; } }
        [DataMember]
        public string Password { get { return password; } set { password = value; } }
        [DataMember]
        public string Email { get { return email; } set { email = value; } }
        [DataMember]
        public string Phone { get { return phone; } set { phone = value; } }
       
    }
}
