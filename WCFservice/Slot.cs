using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WCFservice
{
    public class Slot
    {
        private int slotID;
        private string userphone;
        private string time;
        private string city;
        private string status;
        [DataMember]
        public int SlotID { get { return slotID; } set { slotID = value; } }
        [DataMember]
        public string Userphone { get { return userphone; } set { userphone = value; } }
        [DataMember]
        public string Time { get { return time; } set { time = value; } }
        [DataMember]
        public string City { get { return city; } set { city = value; } }
        [DataMember]
        public string Status { get { return status; } set { status = value; } }
    }
}
