using Client.HospitalReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class BookSlot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["phone"] != null)
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
            if(Session["phone"] != null)
            {
                Slot slot = new Slot();
                slot.Status = "Booked";
                slot.Time = dropdown_time.SelectedValue;
                slot.City = dropdown_city.SelectedValue;
                slot.Userphone = (string)Session["phone"];
                sc.SetSlot(slot);
            }
            else
            {
                errlogin.Text = "Please Login First";
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