using Client.HospitalReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class Status : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["phone"] != null)
            {
                string loginphone = (string)Session["phone"];
                string loginpass = (string)Session["password"];
                HospitalReference.HospitalServiceClient sc = new HospitalReference.HospitalServiceClient();
                User user = sc.GetUser(loginphone, loginpass);
                Slot slot = sc.GetSlot(loginphone);
                if (user != null)
                {
                    navuser.Text = user.Name;
                    namefromdb.Text = user.Name;
                    emaildb.Text = user.Email;
                    contactdb.Text = user.Phone;

                    if (slot != null)
                    {
                        bookstatusdb.Text = slot.Status;
                        timedb.Text = slot.Time;
                    }
                    else
                    {
                        timedb.Text = "-";
                        bookstatusdb.Text = "Pending";
                    }
                }
                else
                {
                    navuser.Text = "Please Login";
                }
            }
            else
            {
                navuser.Text = "Please Login";
            }
        }

        protected void logoutbutton_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            navuser.Text = "";
            namefromdb.Text = "";
            emaildb.Text = "";
            contactdb.Text = "";
            bookstatusdb.Text = "";
            timedb.Text = "";
            navuser.Text = "Please Login";
        }
    }
}