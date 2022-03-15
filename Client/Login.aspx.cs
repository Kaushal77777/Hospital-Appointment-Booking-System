using Client.HospitalReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if(Session["phone"] != null)
            {
                string loginphone = (string)Session["phone"];
                string loginpass = (string)Session["password"];
                HospitalReference.HospitalServiceClient sc = new HospitalReference.HospitalServiceClient();
                User user = sc.GetUser(loginphone, loginpass);
                if (user != null)
                {
                    navuser.Text = user.Name;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            HospitalReference.HospitalServiceClient sc = new HospitalReference.HospitalServiceClient();
            if(phone.Text != "" && password.Text != "")
            {
                User user = sc.GetUser(phone.Text, password.Text);
                if (user != null)
                {
                    Session["phone"] = user.Phone;
                    Session["password"] = user.Password;
                    Response.Redirect("BookSlot.aspx");
                }
                else
                {
                    errmsg.Text = "Invalid Credentials";
                }
            }
            else
            {
                errmsg.Text= "Please Fill All Required Fields";
            }
            
        }

        protected void logoutbutton_Click(object sender, EventArgs e)
        {
            navuser.Text = "Please Login";
            Session.Clear();
            Session.Abandon();
        }
    }
}